using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagazineSystem : MonoBehaviour
{
    [Header("弾数")]
    public int m_Bullets;
    [Header("最大弾数")]
    public int m_MaxBullets;
    [Header("マガジンの型式")]
    public string m_MagazineType;
    [Header("物理当たり判定")]
    public BoxCollider m_MagazineCollider;

    /// <summary>
    /// 廃棄する
    /// マガジンを銃器から排除する
    /// </summary>
    public void Purge()
    {
        //自身をパージする
        this.transform.parent = null;
        //自身の下方向へ排出する
        this.GetComponent<Rigidbody>().AddForce(-this.transform.up * 100.0f);
        //トリガーを無効にする
        m_MagazineCollider.isTrigger = false;
    }
}
