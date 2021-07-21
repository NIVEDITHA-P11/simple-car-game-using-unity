
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform playerps;
    public Vector3 vector; 

    // Update is called once per frame
    void Update()
    {
        transform.position = playerps.position+vector;
        
    }
}
