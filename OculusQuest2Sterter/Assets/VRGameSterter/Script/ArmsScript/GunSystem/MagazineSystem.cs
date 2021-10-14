using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagazineSystem : MonoBehaviour
{
    [Header("�e��")]
    public int m_Bullets;
    [Header("�ő�e��")]
    public int m_MaxBullets;
    [Header("�}�K�W���̌^��")]
    public string m_MagazineType;
    [Header("���������蔻��")]
    public BoxCollider m_MagazineCollider;

    /// <summary>
    /// �p������
    /// �}�K�W�����e�킩��r������
    /// </summary>
    public void Purge()
    {
        //���g���p�[�W����
        this.transform.parent = null;
        //���g�̉������֔r�o����
        this.GetComponent<Rigidbody>().AddForce(-this.transform.up * 100.0f);
        //�g���K�[�𖳌��ɂ���
        m_MagazineCollider.isTrigger = false;
    }
}
