using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxpick : MonoBehaviour
{
    int kuji_count = 20;
    bool handin = false;
    bool getkuji = false;
    bool pick = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //�N�W��������u�Ԃɔ�������
        if (pick == true)
        {
            if (kuji_count == 0) return;
            int result = Random.Range(0, kuji_count);
            if (result != Random.Range(0, kuji_count))
            {
                kuji_count--;
            }
            else
            {
                kuji_count = 0;
            }
            getkuji = true;
        }
        if (!handin && getkuji && kuji_count > 0)
        {
            //�肪����Ă���N�W�𐶐�
            getkuji = false;
        }
    }
}
