using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ���蕺���Ɋւ���}�E���g�Ɠ���
/// </summary>
public class VRMountHundSystem : MonoBehaviour
{
    [Header("�l������A�C�e���^�C�v")]
    public List<string> m_GetItemType;
    [Header("�������Ă���}�E���g�ς݂̃A�C�e���I�u�W�F�N�g")]
    public GameObject m_MountItem;
    [Header("���̃v���O�����͉E��:true ����:false")]
    public bool m_HundType;

    private void LateUpdate()
    {
        
    }

    void HoldDropItem()
    {
        if (m_MountItem)
        {
            if ()
            {
                m_MountItem.transform.position = this.transform.position;
                m_MountItem.transform.rotation = this.transform.rotation;
            }
        }
    }


    /// <summary>
    /// �ڐG����
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerStay(Collider other)
    {
        ItemGetSystem(other.gameObject);
    }

    /// <summary>
    /// �A�C�e����F�؂��A�Y���A�C�e��������ꍇ�}�E���g�A�C�e���Ƃ���
    /// </summary>
    /// <param name="GetObjectData"></param>
    void ItemGetSystem(GameObject GetObjectData)
    {
        //�}�E���g�A�C�e�����Ȃ�
        if (!m_MountItem)
        {
            //�ڐG���Ă���I�u�W�F�N�g���AItemIDsystem�R���|�[�l���g������
            if (GetObjectData.GetComponent<ItemIDSystem>())
            {
                //ItemID���l��
                string ItemIDName = GetObjectData.GetComponent<ItemIDSystem>().m_ItemID;
                //��������Ń`�F�b�N
                foreach (string Dummy in m_GetItemType)
                {
                    //IteamID�̖��O������ł���
                    if (Dummy == ItemIDName)
                    {
                        //�Y������I�u�W�F�N�g���}�E���g����
                        m_MountItem = GetObjectData;
                        GetObjectData.transform.position = this.transform.position;
                        GetObjectData.transform.rotation = this.transform.rotation;
                        GetObjectData.transform.parent = this.transform;
                        break;
                    }
                }
            }
        }
    }
}
