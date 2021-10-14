using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagazineMountSystem : MonoBehaviour
{
    [Header("�e�V�X�e�������N")]
    public GunSystem m_GunSystem;
    [Header("�}�K�W���̌^��")]
    public string m_MagazineType;

    void Start()
    {
        //�e�V�X�e�������݂��Ȃ�
        if (!m_GunSystem)
        {
            //�}�K�W���}�E���g�̐e�I�u�W�F�N�g�ɂ���ꍇ
            if (this.transform.parent.GetComponent<GunSystem>())
                m_GunSystem = this.transform.parent.GetComponent<GunSystem>();
        }
    }

    #region �}�K�W�����}�E���g�ɐڐG�����ꍇ
    /// <summary>
    /// �}�K�W�����}�E���g�ɐڐG�����ꍇ
    /// </summary>
    /// <param name="other"> �ڐG�����I�u�W�F�N�g</param>
    private void OnTriggerEnter(Collider other)
    {
        if (!m_GunSystem.m_MagazineSystem)
        {
            //�ڐG�Ώۂ��AMagazine�̃^�O�������Ă���
            if (other.gameObject.tag == "Magazine")
            {
                //�ڐG�Ώۂ��AMagazineSystem�R���|�[�l���g��L���Ă���
                if (other.gameObject.GetComponent<MagazineSystem>())
                {
                    //�ڐG�Ώۂ̃}�K�W���^�����A�}�E���g���̌^���ƍ��v����
                    if (other.gameObject.GetComponent<MagazineSystem>().m_MagazineType
                        == m_MagazineType)
                    {
                        //�e�V�X�e�����Ƀ}�E���g���Ă���}�K�W�����Ȃ�
                        if (!m_GunSystem.m_MagazineSystem)
                        {
                            //�e�V�X�e���̃}�K�W���V�X�e���V�X�e���ƃ����N����
                            m_GunSystem.m_MagazineSystem = other.gameObject.GetComponent<MagazineSystem>();
                            m_GunSystem.m_MagazineSystem.m_MagazineCollider.isTrigger = true;
                            //�}�K�W���I�u�W�F�N�g�̈ʒu�A���������킹��
                            other.transform.position = this.transform.position;
                            other.transform.rotation = this.transform.rotation;
                            //�}�K�W���}�E���g��e�Ƃ��Đݒ肵�A��������
                            other.transform.parent = this.transform;
                        }
                    }
                }
            }
        }
    }
    #endregion
}
