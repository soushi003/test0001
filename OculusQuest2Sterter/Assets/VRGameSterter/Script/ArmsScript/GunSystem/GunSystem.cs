using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �Ζ򎮏e�V�X�e��
/// </summary>
public class GunSystem : MonoBehaviour
{
    [Header("��Ɏ����Ă���ꍇ�A�N�e�B�u�ɂȂ�")]
    public bool IsActive = false;
    [Header("�e��")]
    public List<Transform> m_Muzzle;
    [Header("�e�۔��˃N�[���^�C��")]
    public float m_FireBlank;
    [Header("�e�۔��ˍő�N�[���^�C��")]
    public float m_MaxFireBlank = 0.25f;
    [Header("�e�ۖ{��")]
    public GameObject m_Bullet;
    [Header("�����I�Ζ��")]
    public float m_PhysicalFirePower = 3000.0f;
    [Header("[Auto]�}�K�W���V�X�e��")]
    public MagazineSystem m_MagazineSystem;
    /// <summary>
    /// �����N��
    /// </summary>
    void Start()
    {
        //�t�@�C���[�u�����N������������
        m_FireBlank = m_MaxFireBlank;
    }

    /// <summary>
    /// �t���[���X�V
    /// </summary>
    void Update()
    {
        //�N�[���^�C�����s
        CoolTime();
    }

    #region �N�[���^�C������
    /// <summary>
    /// �N�[���^�C������
    /// </summary>
    void CoolTime()
    {
        //���ݏ��������A�}�K�W�����}�E���g���Ă���
        if (IsActive && m_MagazineSystem)
        {
            //���˃N�[���^�C�������Ԍ���
            m_FireBlank -= 1.0f * Time.deltaTime;
            //�N�[���^�C���������E����
            if (m_FireBlank <= 0.0f)
                m_FireBlank = 0.0f;
        }
    }
    #endregion

    #region �g���K�[�����������̏���
    /// <summary>
    /// �g���K�[�����������̏���
    /// </summary>
    public void Trigger()
    {
        //���������A�}�K�W�����}�E���g���Ă���
        if (IsActive && m_MagazineSystem)
        {
            //�e���˃N�[���^�C����0�ȉ��ł���
            if (m_FireBlank <= 0.0f)
            {
                //�e�������J��Ԃ�
                foreach (Transform Dummy in m_Muzzle)
                {
                    //�}�E���g���Ă���}�K�W���̒e����0�ȉ�?
                    if (m_MagazineSystem.m_Bullets > 0)
                    {
                        //�e�ۂ�1�����
                        m_MagazineSystem.m_Bullets--;
                        Fire(Dummy);
                    }
                }
                //���˃N�[���^�C����������
                m_FireBlank = m_MaxFireBlank;
            }
        }
    }
    #endregion

    #region ���C����
    /// <summary>
    /// ���C����
    /// </summary>
    /// <param name="Muzzle"></param>
    void Fire(Transform Muzzle)
    {
        //�e�����e���ʒu�A�y�ь����ɐݒu����
        GameObject Dummy = Instantiate(
            m_Bullet,
            Muzzle.position,
            Muzzle.rotation);

        //�e���ɕ����������Ă��Ȃ��ꍇ�́A������ǉ�����
        if (!Dummy.GetComponent<Rigidbody>())
            Dummy.AddComponent<Rigidbody>();

        //�e���̕����ɕ����I�ȉΖ�ʕ��̗͂�������
        Dummy.GetComponent<Rigidbody>().AddForce(Muzzle.forward * m_PhysicalFirePower, ForceMode.Impulse);
        //5�b��ɒe�����ŗ\��
        Destroy(Dummy, 5.0f);
    }
    #endregion

    #region �}�K�W���p��
    /// <summary>
    /// �p������
    /// �}�K�W�����e�킩��r������
    /// </summary>
    public void Purge()
    {
        //�}�K�W�����Ńp�[�W���������s����
        m_MagazineSystem.Purge();
        //�}�K�W���V�X�e���̃����N���O��
        m_MagazineSystem = null;
    }
    #endregion
}