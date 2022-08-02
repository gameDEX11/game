using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hit : MonoBehaviour
{
    public enemyMovement Enemy;
    public Rigidbody2D enemy;
    
    void Start()
    {
     
    }
    public void hitForce()
    {
        if(Enemy.enemySide())
    {
        enemy.AddForce(Vector2.right*1000f);
    }
    else
    {
        enemy.AddForce(Vector2.left*1000f);
    }
        
    }
   
}
