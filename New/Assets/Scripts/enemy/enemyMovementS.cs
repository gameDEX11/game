using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class enemyMovementS : MonoBehaviour
{
    bool isFacingLeft=true;
    float enemyUpWay;
    float enemyWay;
    Rigidbody2D playerBody;
    public playerMovement rb;
    public Rigidbody2D enemy;
    void Start()
    {
        rb=FindObjectOfType<playerMovement>();
        playerBody=rb.GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if((isFacingLeft&&enemyWay>0)||(!isFacingLeft&&enemyWay<0))
        {
            Vector3 localScale=transform.localScale;
            localScale.x*=-1f;
            transform.localScale=localScale;
            isFacingLeft=!isFacingLeft;
        }
        Debug.Log(enemyWay);

    }
    void FixedUpdate()
    {
        if((enemy.transform.position.x)>(playerBody.transform.position.x))
        {
            enemyWay=-1f;
        }
        else
        {
            enemyWay=1f;
        } 
        if((enemy.transform.position.y)<(playerBody.transform.position.y))
        {
            enemyUpWay=1f;
        
        }
        else
        {
            enemyUpWay=-1f;
        }
        enemy.velocity=new Vector2(enemyWay*3f,enemyUpWay*3f);

    }
   
}
