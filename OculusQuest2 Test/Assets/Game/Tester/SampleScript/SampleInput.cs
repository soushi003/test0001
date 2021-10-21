using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleInput : MonoBehaviour
{

    void Update()
    {
        #region �{�^������
        if (OVRInput.GetDown(OVRInput.RawButton.A))
        {
            Debug.Log("A�{�^����������");
        }
        if (OVRInput.GetDown(OVRInput.RawButton.B))
        {
            Debug.Log("B�{�^����������");
        }
        if (OVRInput.GetDown(OVRInput.RawButton.X))
        {
            Debug.Log("X�{�^����������");
        }
        if (OVRInput.GetDown(OVRInput.RawButton.Y))
        {
            Debug.Log("Y�{�^����������");
        }
        if (OVRInput.GetDown(OVRInput.RawButton.Start))
        {
            Debug.Log("���胁�j���[�{�^�����������i�I���E�I�t�s����Ȃ̂Œ��Ӂj");
        }
        #endregion

        #region �g���K�[����
        if (OVRInput.GetDown(OVRInput.RawButton.RIndexTrigger))
        {
            Debug.Log("�E�l�����w�g���K�[��������");
        }
        if (OVRInput.GetDown(OVRInput.RawButton.RHandTrigger))
        {
            Debug.Log("�E���w�O���b�v��������");
        }
        if (OVRInput.GetDown(OVRInput.RawButton.LIndexTrigger))
        {
            Debug.Log("���l�����w�g���K�[��������");
        }
        if (OVRInput.GetDown(OVRInput.RawButton.LHandTrigger))
        {
            Debug.Log("�����w�O���b�v��������");
        }
        // �E�l�����w�g���K�[
        float rTrigger1 = OVRInput.Get(OVRInput.RawAxis1D.RIndexTrigger);
        // �E���w�O���b�v
        float rTrigger2 = OVRInput.Get(OVRInput.RawAxis1D.RHandTrigger);
        // ���l�����w�g���K�[
        float lTrigger1 = OVRInput.Get(OVRInput.RawAxis1D.LIndexTrigger);
        // �����w�O���b�v
        float lTrigger2 = OVRInput.Get(OVRInput.RawAxis1D.LHandTrigger);
        #endregion

        #region �I���L�����Z���{�^������
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            Debug.Log("�I������[A/X �{�^��]");
        }
        if (OVRInput.GetDown(OVRInput.Button.Two))
        {
            Debug.Log("�L�����Z������[B/Y �{�^��]");
        }
        #endregion

        #region �A�i���O�W���C�X�e�B�b�N����
        // ����̃A�i���O�X�e�B�b�N�̌������擾
        Vector2 stickL = OVRInput.Get(OVRInput.RawAxis2D.LThumbstick);
        // �E��̃A�i���O�X�e�B�b�N�̌������擾
        Vector2 stickR = OVRInput.Get(OVRInput.RawAxis2D.RThumbstick);


        if (OVRInput.GetDown(OVRInput.RawButton.LThumbstick))
        {
            Debug.Log("���A�i���O�X�e�B�b�N����������");
        }
        if (OVRInput.GetDown(OVRInput.RawButton.RThumbstick))
        {
            Debug.Log("�E�A�i���O�X�e�B�b�N����������");
        }

        if (OVRInput.GetDown(OVRInput.RawButton.LThumbstickUp))
        {
            Debug.Log("���A�i���O�X�e�B�b�N����ɓ|����");
        }
        if (OVRInput.GetDown(OVRInput.RawButton.LThumbstickDown))
        {
            Debug.Log("���A�i���O�X�e�B�b�N�����ɓ|����");
        }
        if (OVRInput.GetDown(OVRInput.RawButton.LThumbstickLeft))
        {
            Debug.Log("���A�i���O�X�e�B�b�N�����ɓ|����");
        }
        if (OVRInput.GetDown(OVRInput.RawButton.LThumbstickRight))
        {
            Debug.Log("���A�i���O�X�e�B�b�N���E�ɓ|����");
        }

        if (OVRInput.GetDown(OVRInput.RawButton.RThumbstickUp))
        {
            Debug.Log("�E�A�i���O�X�e�B�b�N����ɓ|����");
        }
        if (OVRInput.GetDown(OVRInput.RawButton.RThumbstickDown))
        {
            Debug.Log("�E�A�i���O�X�e�B�b�N�����ɓ|����");
        }
        if (OVRInput.GetDown(OVRInput.RawButton.RThumbstickLeft))
        {
            Debug.Log("�E�A�i���O�X�e�B�b�N�����ɓ|����");
        }
        if (OVRInput.GetDown(OVRInput.RawButton.RThumbstickRight))
        {
            Debug.Log("�E�A�i���O�X�e�B�b�N���E�ɓ|����");
        }
        #endregion

        #region �ڐG����
        if (OVRInput.Get(OVRInput.RawTouch.LIndexTrigger))
        {
            Debug.Log("���l�����w�p�g���K�[�ɐG��Ă���");
        }
        if (OVRInput.Get(OVRInput.RawTouch.LThumbstick))
        {
            Debug.Log("���A�i���O�X�e�B�b�N�ɐG��Ă���");
        }

        if (OVRInput.Get(OVRInput.RawTouch.RIndexTrigger))
        {
            Debug.Log("�E�l�����w�p�g���K�[�ɐG��Ă���");
        }
        if (OVRInput.Get(OVRInput.RawTouch.RThumbstick))
        {
            Debug.Log("�E�A�i���O�X�e�B�b�N�ɐG��Ă���");
        }

        if (OVRInput.Get(OVRInput.RawTouch.A))
        {
            Debug.Log("A�{�^���ɐG��Ă���");
        }
        if (OVRInput.Get(OVRInput.RawTouch.B))
        {
            Debug.Log("B�{�^���ɐG��Ă���");
        }
        if (OVRInput.Get(OVRInput.RawTouch.X))
        {
            Debug.Log("X�{�^���ɐG��Ă���");
        }
        if (OVRInput.Get(OVRInput.RawTouch.Y))
        {
            Debug.Log("Y�{�^���ɐG��Ă���");
        }

        if (OVRInput.Get(OVRInput.RawNearTouch.LIndexTrigger))
        {
            Debug.Log("���l�����w�p�g���K�[�̋߂��Ɏw������");
        }
        if (OVRInput.Get(OVRInput.RawNearTouch.LThumbButtons))
        {
            Debug.Log("���A�i���O�X�e�B�b�N�̋߂��Ɏw������");
        }

        if (OVRInput.Get(OVRInput.RawNearTouch.RIndexTrigger))
        {
            Debug.Log("�E�l�����w�p�g���K�[�̋߂��Ɏw������");
        }
        if (OVRInput.Get(OVRInput.RawNearTouch.RThumbButtons))
        {
            Debug.Log("�E�A�i���O�X�e�B�b�N�̋߂��Ɏw������");
        }
        #endregion

        #region �U������
        // �E��g���K�[����������U�����J�n
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch))
        {
            OVRInput.SetControllerVibration(0f, 1f, OVRInput.Controller.RTouch);
        }
        // �E��g���K�[�𗣂�����U�����~
        if (OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch))
        {
            OVRInput.SetControllerVibration(0f, 0f, OVRInput.Controller.RTouch);
        }
        #endregion
    }
}
