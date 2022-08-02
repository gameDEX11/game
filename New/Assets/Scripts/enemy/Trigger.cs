using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    float time = 0f;
    Animator animator;
    public GameObject enemy;
    float keepHit=0;
    public hit Hit;
    void Start()
    {
        animator=GetComponent<Animator>();
    }
    void Update()
    {
        time += Time.deltaTime;
        Debug.Log(time);    
    }

    private void OnTriggerStay2D(Collider2D col)
    {
       
        if(col.CompareTag("Trident"))
        {
            if(Input.GetMouseButton(0))
        {
                if(time>=1f)
                {
                    Hit.hitForce();
                    animator.SetTrigger("Hit");
                    time = 0f;
                }  
        }
        }
       
    }
}
