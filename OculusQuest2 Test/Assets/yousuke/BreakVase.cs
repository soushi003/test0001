using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakVase : MonoBehaviour
{

    Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        //�����u�Ԃ̑��x�����ȏ�Ȃ犄��鏈���Ɉڂ�
        Debug.Log("���x�x�N�g���F"+rigidbody.velocity.magnitude);

        float break_power = 2.0f;

        if (rigidbody.velocity.magnitude >= break_power)
        {
            Debug.Log("����܂��I");

        }
    }

}
