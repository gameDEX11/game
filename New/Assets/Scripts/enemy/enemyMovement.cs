using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
   float enemyPosition;
   float playerPosition;
   float distance;
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
        enemyPosition=enemy.transform.position.x;
        playerPosition=playerBody.transform.position.x;
        distance=enemyPosition-playerPosition;
        if((isFacingLeft&&distance<0f)||(!isFacingLeft&&distance>0.5f))
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
        if(((enemyPosition)-1f)<(playerPosition))
        {
            enemyWay=0.5f;
           

        }
        else if(((enemyPosition)-1f)>(playerPosition))
        {
            enemyWay=-1f;
        } 
        else
        {
            enemyWay=0f;
        }
        if(((enemy.transform.position.y)-2f)<(playerBody.transform.position.y))
        {
            enemyUpWay=0.5f;
        
        }
        else
        {
            enemyUpWay=-1f;
        }
        enemy.velocity=new Vector2(enemyWay*3f,enemyUpWay*3f);
    }
    public bool enemySide()
    {
         return isFacingLeft;
    }
   
}
