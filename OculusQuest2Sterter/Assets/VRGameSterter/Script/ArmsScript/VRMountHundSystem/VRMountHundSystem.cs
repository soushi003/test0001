using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 両手兵装に関するマウントと入力
/// </summary>
public class VRMountHundSystem : MonoBehaviour
{
    [Header("獲得するアイテムタイプ")]
    public List<string> m_GetItemType;
    [Header("所持しているマウント済みのアイテムオブジェクト")]
    public GameObject m_MountItem;
    [Header("このプログラムは右手:true 左手:false")]
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
    /// 接触判定
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerStay(Collider other)
    {
        ItemGetSystem(other.gameObject);
    }

    /// <summary>
    /// アイテムを認証し、該当アイテムがある場合マウントアイテムとする
    /// </summary>
    /// <param name="GetObjectData"></param>
    void ItemGetSystem(GameObject GetObjectData)
    {
        //マウントアイテムがない
        if (!m_MountItem)
        {
            //接触しているオブジェクトが、ItemIDsystemコンポーネントがある
            if (GetObjectData.GetComponent<ItemIDSystem>())
            {
                //ItemIDを獲得
                string ItemIDName = GetObjectData.GetComponent<ItemIDSystem>().m_ItemID;
                //総当たりでチェック
                foreach (string Dummy in m_GetItemType)
                {
                    //IteamIDの名前が同一である
                    if (Dummy == ItemIDName)
                    {
                        //該当するオブジェクトをマウントする
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
