using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mystery_Safe : MonoBehaviour
{
    int upC, rC, downC, lC = 0;
    int upD, rD, downD, lD = 0;
    int putD = 0;
    int setD = 0;
    //触れている
    bool hand = true;
    // Start is called before the first frame update
    void Start()
    {
        upC = 3;
        rC = 3;
        downC = 2;
        lD = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (hand)
        {
            //回転に応じてputDを変更
        }
        else if (!hand&&setD!=putD)
        {
            setD = putD;
            switch (setD)
            {
                case 0:upD++; break;
                case 1:rD++; break;
                case 2:downD++; break;
                case 3:lD++; break;
            }
            if (upD == upC && rD == rC && downD == downC && lD == lC)
            {
                //解除
            }
            else if(upD > upC || rD > rC || downD > downC || lD > lC)
            {
                //リセット
                upD = rD = downD = lD = 0;
                setD = 0;
                putD = 0;
            }
        }
    }
}
