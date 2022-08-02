using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    Animator animator;
    public GameObject enemy;
    float keepHit=0;
    public hit Hit;
    void Start()
    {
        animator=GetComponent<Animator>();
    }

    private void OnTriggerStay2D(Collider2D col)
    {
       
        if(col.gameObject.CompareTag("Trident"))
        {
            if(Input.GetMouseButton(0))
        {
            Hit.hitForce();
            animator.SetTrigger("Hit");
            Debug.Log("we hit something");
            //keepHit++;
            if(keepHit==3)
            {
                Destroy(enemy);
            }
            
        }
        }
        if(col.gameObject.CompareTag("Player"))
        {
            
        }
    }
}
