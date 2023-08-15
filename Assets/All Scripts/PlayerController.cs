using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    public float speed;
    public float jumpForce;
    private float moveInput;
    private Rigidbody2D rb;
    private bool facingRight = true;
    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;
    int extraJumps;
    public int extraJumpsValue;
    private bool isDead = false;

    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        extraJumps = extraJumpsValue;
        rb = GetComponent<Rigidbody2D>();

        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Jump();
        isGrounded = Physics2D.OverlapCircle(groundCheck.position,checkRadius,whatIsGround);

        
        //Debug.Log(extraJumps);
        //Debug.Log(isGrounded);
        rb.velocity = new Vector2(moveInput * speed,rb.velocity.y);

        if(facingRight == false && moveInput > 0){
            Debug.Log("flip");
            Flip();
            
            
        }else if (facingRight == true && moveInput < 0)
        {
            Debug.Log("flip");
            Flip();
            
        }

        if(moveInput != 0)
        {
            anim.SetBool("DogWALK", true);
        }
        else
        {
            anim.SetBool("DogWALK", false);
        }
    }
    void Update(){
        
         moveInput = Input.GetAxis("Horizontal");

    }

    void Jump(){
        if(isGrounded == true){
            extraJumps = extraJumpsValue;
        }
        if(Input.GetKeyDown(KeyCode.UpArrow) && extraJumps > 0){
            rb.velocity = Vector2.zero;
            rb.velocity = Vector2.up * jumpForce;
            //Debug.Log("Jump!");
            extraJumps--;
        }else if(Input.GetKeyDown(KeyCode.UpArrow)  && extraJumps == 0 && isGrounded == true){
            rb.velocity = Vector2.up * jumpForce;
        }
    }
    void Flip(){
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
        
    }

 
 
    
void Die(){
        SceneManager.LoadScene(0);
        }
    }



    




