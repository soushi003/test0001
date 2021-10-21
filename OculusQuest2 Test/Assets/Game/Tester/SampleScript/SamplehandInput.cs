using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SamplehandInput : MonoBehaviour
{
    [SerializeField,Header("ハンドを入れる")]
    OVRHand ovrHand;
    void Update()
    {
        /*
         指            finger の値
         親指          OVRHand.HandFinger.Thumb
         人差し指      OVRHand.HandFinger.Index
         中指          OVRHand.HandFinger.Middle
         薬指          OVRHand.HandFinger.Ring
         小指          OVRHand.HandFinger.Pinky
         */

        //つまむ処理
        if (ovrHand.GetFingerIsPinching(OVRHand.HandFinger.Index) &&
            ovrHand.GetFingerIsPinching(OVRHand.HandFinger.Thumb))
        {
            Debug.Log("人差し指と親指で摘まんでいる。");
        }

        //タッチコントローラーか、ハンドトラッキングモードかを確認する。
        //切り替わる瞬間は両方ともfalseとなる。
        bool usingHand = OVRInput.IsControllerConnected(OVRInput.Controller.Hands);
        bool usingTouch = OVRInput.IsControllerConnected(OVRInput.Controller.Touch);

        Debug.Log($"ハンドモード = {usingHand} / コントローラーモード = {usingTouch}");

    }
}
