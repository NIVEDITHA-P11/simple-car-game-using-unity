using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PMov : MonoBehaviour
{
    public Rigidbody rb;
    public float force = 2000f;

    public float sidewaysforce = 500f;

    
    void FixedUpdate()
    {
        rb.AddForce(force * Time.deltaTime,0, 0);
        rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;

        if (Input.GetKey("d"))
        {
            rb.AddForce(0, 0, -sidewaysforce * Time.deltaTime);
 
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(0, 0, sidewaysforce * Time.deltaTime);

        }
    }
}
