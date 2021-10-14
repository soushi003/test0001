using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagazineSystem : MonoBehaviour
{
    [Header("’e”")]
    public int m_Bullets;
    [Header("Å‘å’e”")]
    public int m_MaxBullets;
    [Header("ƒ}ƒKƒWƒ“‚ÌŒ^®")]
    public string m_MagazineType;
    [Header("•¨—“–‚½‚è”»’è")]
    public BoxCollider m_MagazineCollider;

    /// <summary>
    /// ”pŠü‚·‚é
    /// ƒ}ƒKƒWƒ“‚ğeŠí‚©‚ç”rœ‚·‚é
    /// </summary>
    public void Purge()
    {
        //©g‚ğƒp[ƒW‚·‚é
        this.transform.parent = null;
        //©g‚Ì‰º•ûŒü‚Ö”ro‚·‚é
        this.GetComponent<Rigidbody>().AddForce(-this.transform.up * 100.0f);
        //ƒgƒŠƒK[‚ğ–³Œø‚É‚·‚é
        m_MagazineCollider.isTrigger = false;
    }
}
