using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Rigidbody rb;
    public int force = 650;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //rb.angularVelocity = Vector3.zero;
            //rb.velocity = Vector3.zero;
            rb.AddForce(Vector3.forward * force * Time.unscaledDeltaTime * 5f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            //rb.angularVelocity = Vector3.zero;
            //rb.velocity = Vector3.zero;
            rb.AddForce(Vector3.right * force * Time.unscaledDeltaTime * 5f);
        }

        if (Input.GetKey(KeyCode.A))
        {
            //rb.angularVelocity = Vector3.zero;
            //rb.velocity = Vector3.zero;
            rb.AddForce(Vector3.left * force * Time.unscaledDeltaTime * 5f);
        }

        if (Input.GetKey(KeyCode.S))
        {
            //rb.angularVelocity = Vector3.zero;
            //rb.velocity = Vector3.zero;
            rb.AddForce(Vector3.back * force * Time.unscaledDeltaTime * 5f);
        }
    }
}
