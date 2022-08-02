using UnityEngine;

public class collision : MonoBehaviour
{
    
    float keepSpeed;
    Rigidbody2D player;
    public playerHealth health;
    private void OnCollisionEnter2D(Collision2D other)
    {
      if(other.gameObject.CompareTag("Spikes"))
      {
        health.takeDamage(20);
        player.velocity=Vector2.up*(keepSpeed+10f);
      }
    }

    
      
     void Update() {
        {
            keepSpeed=-(player.velocity.y);
            if(keepSpeed>5f)
            {
              keepSpeed=5f;
            }
        }
    }
    void Start()
    {
        
       player=GetComponent<Rigidbody2D>();
        
    }

    
}
