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
        //もし瞬間の速度が一定以上なら割れる処理に移る
        Debug.Log("速度ベクトル："+rigidbody.velocity.magnitude);

        float break_power = 2.0f;

        if (rigidbody.velocity.magnitude >= break_power)
        {
            Debug.Log("割れます！");

        }
    }

}
