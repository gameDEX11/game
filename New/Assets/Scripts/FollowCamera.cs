using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
 

    playerMovement followCamera;
    public Vector3 offset;
    public Rigidbody2D follow;

    
    
    void Start()
    {
       followCamera=FindObjectOfType<playerMovement>();
       follow=followCamera.GetComponent<Rigidbody2D>();

    }
   
    void Update()
    {
        transform.position=follow.transform.position+offset;
        
    }
}
