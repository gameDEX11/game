using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    public Transform wallCheck;
    public LayerMask wallLayer;
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
        if (isWall()==true)
        {
            enemy.velocity = new Vector2(0f, 3f);
            Debug.Log("we hit something");
                
        }
        enemyPosition =enemy.transform.position.x;
        playerPosition=playerBody.transform.position.x;
        distance=enemyPosition-playerPosition;
        if((isFacingLeft&&distance<0f)||(!isFacingLeft&&distance>0.5f))
        {
            Vector3 localScale=transform.localScale;
            localScale.x*=-1f;
            transform.localScale=localScale;
            isFacingLeft=!isFacingLeft;
        }
        

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
    public bool isWall()
    {
        return Physics2D.OverlapCircle(wallCheck.position, 0.3f, wallLayer);

    }


}
