using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 火薬式銃システム
/// </summary>
public class GunSystem : MonoBehaviour
{
    [Header("手に持っている場合アクティブになる")]
    public bool IsActive = false;
    [Header("銃口")]
    public List<Transform> m_Muzzle;
    [Header("弾丸発射クールタイム")]
    public float m_FireBlank;
    [Header("弾丸発射最大クールタイム")]
    public float m_MaxFireBlank = 0.25f;
    [Header("弾丸本体")]
    public GameObject m_Bullet;
    [Header("物理的火薬量")]
    public float m_PhysicalFirePower = 3000.0f;
    [Header("[Auto]マガジンシステム")]
    public MagazineSystem m_MagazineSystem;
    /// <summary>
    /// 初期起動
    /// </summary>
    void Start()
    {
        //ファイヤーブランクを初期化する
        m_FireBlank = m_MaxFireBlank;
    }

    /// <summary>
    /// フレーム更新
    /// </summary>
    void Update()
    {
        //クールタイム続行
        CoolTime();
    }

    #region クールタイム処理
    /// <summary>
    /// クールタイム処理
    /// </summary>
    void CoolTime()
    {
        //現在所持中かつ、マガジンがマウントしている
        if (IsActive && m_MagazineSystem)
        {
            //発射クールタイムを時間減少
            m_FireBlank -= 1.0f * Time.deltaTime;
            //クールタイム減少限界処理
            if (m_FireBlank <= 0.0f)
                m_FireBlank = 0.0f;
        }
    }
    #endregion

    #region トリガーを引いた時の処理
    /// <summary>
    /// トリガーを引いた時の処理
    /// </summary>
    public void Trigger()
    {
        //所持中かつ、マガジンがマウントしている
        if (IsActive && m_MagazineSystem)
        {
            //弾発射クールタイムが0以下である
            if (m_FireBlank <= 0.0f)
            {
                //銃口数分繰り返す
                foreach (Transform Dummy in m_Muzzle)
                {
                    //マウントしているマガジンの弾数が0以下?
                    if (m_MagazineSystem.m_Bullets > 0)
                    {
                        //弾丸を1つ消費する
                        m_MagazineSystem.m_Bullets--;
                        Fire(Dummy);
                    }
                }
                //発射クールタイムを初期化
                m_FireBlank = m_MaxFireBlank;
            }
        }
    }
    #endregion

    #region 発砲処理
    /// <summary>
    /// 発砲処理
    /// </summary>
    /// <param name="Muzzle"></param>
    void Fire(Transform Muzzle)
    {
        //弾頭を銃口位置、及び向きに設置する
        GameObject Dummy = Instantiate(
            m_Bullet,
            Muzzle.position,
            Muzzle.rotation);

        //弾頭に物理が入っていない場合は、物理を追加する
        if (!Dummy.GetComponent<Rigidbody>())
            Dummy.AddComponent<Rigidbody>();

        //弾頭の物理に物理的な火薬量分の力を加える
        Dummy.GetComponent<Rigidbody>().AddForce(Muzzle.forward * m_PhysicalFirePower, ForceMode.Impulse);
        //5秒後に弾頭消滅予約
        Destroy(Dummy, 5.0f);
    }
    #endregion

    #region マガジン廃棄
    /// <summary>
    /// 廃棄する
    /// マガジンを銃器から排除する
    /// </summary>
    public void Purge()
    {
        //マガジン側でパージ処理を実行する
        m_MagazineSystem.Purge();
        //マガジンシステムのリンクを外す
        m_MagazineSystem = null;
    }
    #endregion
}