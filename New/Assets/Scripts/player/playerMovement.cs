using UnityEngine;

    
    

public class playerMovement : MonoBehaviour
{
    Animator animator;
    private bool isFacingRight=true;
    private float jumpCounter;
    public float jumpTime;
    private bool isJumping=true;
    public Transform groundCheck;
    public LayerMask groundLayer;
    float jumpingPower=10f;
    public float speedMove=5f;
    float horizontal;
    Rigidbody2D rb;
   // public Restart restart;
   

    [SerializeField] int PlayerDamage;
    [SerializeField] float attackRate;
    float estTime;

    void Start()
    {
        animator=GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        flip();

        estTime += Time.time;
       
        if(horizontal !=0)
        {
            animator.SetBool("isWalking",true);
        }
        else
        {
            animator.SetBool("isWalking",false);
        }
        if(IsGrounded()&&Input.GetKeyDown(KeyCode.Space))
        {   
            rb.velocity=Vector2.up*jumpingPower;            
            isJumping=true;
            
            jumpCounter=jumpTime;
        }  
         if(Input.GetKey(KeyCode.Space)&&isJumping==true)
        {
            if(jumpCounter>0)
            {
               rb.velocity= Vector2.up*jumpingPower;
                jumpCounter-=Time.deltaTime;
            }
            else
            {
                isJumping=false;
                
            }  
        }
         if(Input.GetKeyUp(KeyCode.Space))
        {
            isJumping=false;
            
        }
         if(Input.GetMouseButton(0) && estTime > attackRate)
        {
            animator.SetTrigger("Attack");
        }
       
       

       
         
    }
    void FixedUpdate()
    {
        rb.velocity=new Vector2(horizontal*speedMove,rb.velocity.y);
    }
     public bool IsGrounded()
    {
        animator.SetBool("isJumping", !Physics2D.OverlapCircle(groundCheck.position, 0.3f, groundLayer));
        return Physics2D.OverlapCircle(groundCheck.position,0.3f,groundLayer);
    }
    public void slowDown(float speed)
    {
        speedMove=speed;
    }
    public void setSpeed(float speed)
    {
        speedMove=speed;
    }
    void flip()
    {
        if((isFacingRight&&horizontal<0) || (!isFacingRight&&horizontal>0))
        {
            isFacingRight=!isFacingRight;
            Vector3 localScale=transform.localScale;
            localScale.x*=-1f;
            transform.localScale=localScale;    
        }
    }

    
}

