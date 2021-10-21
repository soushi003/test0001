using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleInput : MonoBehaviour
{

    void Update()
    {
        #region ボタン制御
        if (OVRInput.GetDown(OVRInput.RawButton.A))
        {
            Debug.Log("Aボタンを押した");
        }
        if (OVRInput.GetDown(OVRInput.RawButton.B))
        {
            Debug.Log("Bボタンを押した");
        }
        if (OVRInput.GetDown(OVRInput.RawButton.X))
        {
            Debug.Log("Xボタンを押した");
        }
        if (OVRInput.GetDown(OVRInput.RawButton.Y))
        {
            Debug.Log("Yボタンを押した");
        }
        if (OVRInput.GetDown(OVRInput.RawButton.Start))
        {
            Debug.Log("左手メニューボタンを押した（オン・オフ不安定なので注意）");
        }
        #endregion

        #region トリガー制御
        if (OVRInput.GetDown(OVRInput.RawButton.RIndexTrigger))
        {
            Debug.Log("右人差し指トリガーを押した");
        }
        if (OVRInput.GetDown(OVRInput.RawButton.RHandTrigger))
        {
            Debug.Log("右中指グリップを押した");
        }
        if (OVRInput.GetDown(OVRInput.RawButton.LIndexTrigger))
        {
            Debug.Log("左人差し指トリガーを押した");
        }
        if (OVRInput.GetDown(OVRInput.RawButton.LHandTrigger))
        {
            Debug.Log("左中指グリップを押した");
        }
        // 右人差し指トリガー
        float rTrigger1 = OVRInput.Get(OVRInput.RawAxis1D.RIndexTrigger);
        // 右中指グリップ
        float rTrigger2 = OVRInput.Get(OVRInput.RawAxis1D.RHandTrigger);
        // 左人差し指トリガー
        float lTrigger1 = OVRInput.Get(OVRInput.RawAxis1D.LIndexTrigger);
        // 左中指グリップ
        float lTrigger2 = OVRInput.Get(OVRInput.RawAxis1D.LHandTrigger);
        #endregion

        #region 選択キャンセルボタン制御
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            Debug.Log("選択した[A/X ボタン]");
        }
        if (OVRInput.GetDown(OVRInput.Button.Two))
        {
            Debug.Log("キャンセルした[B/Y ボタン]");
        }
        #endregion

        #region アナログジョイスティック制御
        // 左手のアナログスティックの向きを取得
        Vector2 stickL = OVRInput.Get(OVRInput.RawAxis2D.LThumbstick);
        // 右手のアナログスティックの向きを取得
        Vector2 stickR = OVRInput.Get(OVRInput.RawAxis2D.RThumbstick);


        if (OVRInput.GetDown(OVRInput.RawButton.LThumbstick))
        {
            Debug.Log("左アナログスティックを押し込んだ");
        }
        if (OVRInput.GetDown(OVRInput.RawButton.RThumbstick))
        {
            Debug.Log("右アナログスティックを押し込んだ");
        }

        if (OVRInput.GetDown(OVRInput.RawButton.LThumbstickUp))
        {
            Debug.Log("左アナログスティックを上に倒した");
        }
        if (OVRInput.GetDown(OVRInput.RawButton.LThumbstickDown))
        {
            Debug.Log("左アナログスティックを下に倒した");
        }
        if (OVRInput.GetDown(OVRInput.RawButton.LThumbstickLeft))
        {
            Debug.Log("左アナログスティックを左に倒した");
        }
        if (OVRInput.GetDown(OVRInput.RawButton.LThumbstickRight))
        {
            Debug.Log("左アナログスティックを右に倒した");
        }

        if (OVRInput.GetDown(OVRInput.RawButton.RThumbstickUp))
        {
            Debug.Log("右アナログスティックを上に倒した");
        }
        if (OVRInput.GetDown(OVRInput.RawButton.RThumbstickDown))
        {
            Debug.Log("右アナログスティックを下に倒した");
        }
        if (OVRInput.GetDown(OVRInput.RawButton.RThumbstickLeft))
        {
            Debug.Log("右アナログスティックを左に倒した");
        }
        if (OVRInput.GetDown(OVRInput.RawButton.RThumbstickRight))
        {
            Debug.Log("右アナログスティックを右に倒した");
        }
        #endregion

        #region 接触判定
        if (OVRInput.Get(OVRInput.RawTouch.LIndexTrigger))
        {
            Debug.Log("左人差し指用トリガーに触れている");
        }
        if (OVRInput.Get(OVRInput.RawTouch.LThumbstick))
        {
            Debug.Log("左アナログスティックに触れている");
        }

        if (OVRInput.Get(OVRInput.RawTouch.RIndexTrigger))
        {
            Debug.Log("右人差し指用トリガーに触れている");
        }
        if (OVRInput.Get(OVRInput.RawTouch.RThumbstick))
        {
            Debug.Log("右アナログスティックに触れている");
        }

        if (OVRInput.Get(OVRInput.RawTouch.A))
        {
            Debug.Log("Aボタンに触れている");
        }
        if (OVRInput.Get(OVRInput.RawTouch.B))
        {
            Debug.Log("Bボタンに触れている");
        }
        if (OVRInput.Get(OVRInput.RawTouch.X))
        {
            Debug.Log("Xボタンに触れている");
        }
        if (OVRInput.Get(OVRInput.RawTouch.Y))
        {
            Debug.Log("Yボタンに触れている");
        }

        if (OVRInput.Get(OVRInput.RawNearTouch.LIndexTrigger))
        {
            Debug.Log("左人差し指用トリガーの近くに指がある");
        }
        if (OVRInput.Get(OVRInput.RawNearTouch.LThumbButtons))
        {
            Debug.Log("左アナログスティックの近くに指がある");
        }

        if (OVRInput.Get(OVRInput.RawNearTouch.RIndexTrigger))
        {
            Debug.Log("右人差し指用トリガーの近くに指がある");
        }
        if (OVRInput.Get(OVRInput.RawNearTouch.RThumbButtons))
        {
            Debug.Log("右アナログスティックの近くに指がある");
        }
        #endregion

        #region 振動制御
        // 右手トリガーを引いたら振動を開始
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch))
        {
            OVRInput.SetControllerVibration(0f, 1f, OVRInput.Controller.RTouch);
        }
        // 右手トリガーを離したら振動を停止
        if (OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch))
        {
            OVRInput.SetControllerVibration(0f, 0f, OVRInput.Controller.RTouch);
        }
        #endregion
    }
}
