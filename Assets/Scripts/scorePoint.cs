using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scorePoint : MonoBehaviour
{
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "obstacles")
        {
            scorer.score -=  10;
        }
        
    }

    
}
