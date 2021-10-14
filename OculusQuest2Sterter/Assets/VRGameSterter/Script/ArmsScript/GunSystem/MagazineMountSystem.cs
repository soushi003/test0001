using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagazineMountSystem : MonoBehaviour
{
    [Header("銃システムリンク")]
    public GunSystem m_GunSystem;
    [Header("マガジンの型式")]
    public string m_MagazineType;

    void Start()
    {
        //銃システムが存在しない
        if (!m_GunSystem)
        {
            //マガジンマウントの親オブジェクトにある場合
            if (this.transform.parent.GetComponent<GunSystem>())
                m_GunSystem = this.transform.parent.GetComponent<GunSystem>();
        }
    }

    #region マガジンがマウントに接触した場合
    /// <summary>
    /// マガジンがマウントに接触した場合
    /// </summary>
    /// <param name="other"> 接触したオブジェクト</param>
    private void OnTriggerEnter(Collider other)
    {
        if (!m_GunSystem.m_MagazineSystem)
        {
            //接触対象が、Magazineのタグを持っている
            if (other.gameObject.tag == "Magazine")
            {
                //接触対象が、MagazineSystemコンポーネントを有している
                if (other.gameObject.GetComponent<MagazineSystem>())
                {
                    //接触対象のマガジン型式が、マウント側の型式と合致する
                    if (other.gameObject.GetComponent<MagazineSystem>().m_MagazineType
                        == m_MagazineType)
                    {
                        //銃システム側にマウントしているマガジンがない
                        if (!m_GunSystem.m_MagazineSystem)
                        {
                            //銃システムのマガジンシステムシステムとリンクする
                            m_GunSystem.m_MagazineSystem = other.gameObject.GetComponent<MagazineSystem>();
                            m_GunSystem.m_MagazineSystem.m_MagazineCollider.isTrigger = true;
                            //マガジンオブジェクトの位置、向きを合わせる
                            other.transform.position = this.transform.position;
                            other.transform.rotation = this.transform.rotation;
                            //マガジンマウントを親として設定し、結合する
                            other.transform.parent = this.transform;
                        }
                    }
                }
            }
        }
    }
    #endregion
}
