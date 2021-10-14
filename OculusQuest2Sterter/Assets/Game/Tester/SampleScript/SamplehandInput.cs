using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SamplehandInput : MonoBehaviour
{
    [SerializeField,Header("�n���h������")]
    OVRHand ovrHand;
    void Update()
    {
        /*
         �w            finger �̒l
         �e�w          OVRHand.HandFinger.Thumb
         �l�����w      OVRHand.HandFinger.Index
         ���w          OVRHand.HandFinger.Middle
         ��w          OVRHand.HandFinger.Ring
         ���w          OVRHand.HandFinger.Pinky
         */

        //�܂ޏ���
        if (ovrHand.GetFingerIsPinching(OVRHand.HandFinger.Index) &&
            ovrHand.GetFingerIsPinching(OVRHand.HandFinger.Thumb))
        {
            Debug.Log("�l�����w�Ɛe�w�œE�܂�ł���B");
        }

        //�^�b�`�R���g���[���[���A�n���h�g���b�L���O���[�h�����m�F����B
        //�؂�ւ��u�Ԃ͗����Ƃ�false�ƂȂ�B
        bool usingHand = OVRInput.IsControllerConnected(OVRInput.Controller.Hands);
        bool usingTouch = OVRInput.IsControllerConnected(OVRInput.Controller.Touch);

        Debug.Log($"�n���h���[�h = {usingHand} / �R���g���[���[���[�h = {usingTouch}");

    }
}
