using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstMov : MonoBehaviour
{
    public Rigidbody myrb;
    public float force = 2000f;

    void Update()
    {
        myrb.AddForce(force * Time.deltaTime, 0, 0);
        myrb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;

        
    }
}
