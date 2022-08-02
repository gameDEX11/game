using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    public int maxHealth=100;
    public int currenthealth;
    public setHealth health;
    // Start is called before the first frame update
    void Start()
    {
    health=FindObjectOfType<setHealth>();
     currenthealth=maxHealth;
    health.setMaxhealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.T))
        {
            takeDamage(20);

        }
    }
     public void takeDamage(int damage)
     {
        currenthealth-=damage;
        health.SetHealth(currenthealth);
     }
}
