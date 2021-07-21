using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scorer : MonoBehaviour
{

    //public PMov p;
    public Rigidbody rb;
    public static int score = 100;

    void Update()
    {

    }
    void OnGUI()
    {
        GUI.Box(new Rect(50, 50, 50, 50), score.ToString());
        if(score==0)
        {
            //rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ;
           rb.constraints=  RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
            //rb.constraints = RigidbodyConstraints.FreezeAll;
            rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ;
        }
    }
    
   
}
