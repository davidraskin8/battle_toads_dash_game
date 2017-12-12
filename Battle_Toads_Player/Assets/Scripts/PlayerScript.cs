using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//***
//Old Player Script for with Jumping and Falling animations
//****
public class PlayerScript : MonoBehaviour {
    public float horizVelocity = 5.0f;
    public float jumpPower = 5.0f;
    Rigidbody2D playerRigidbody;
    private BoxCollider2D boxCol;

    bool isGrounded = false;
    bool hasDoubleJump = false;
    bool canDoubleJump = false;

    private Animator animator;

	// Use this for initialization
	void Start () {
        playerRigidbody = transform.GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        boxCol = GetComponent<BoxCollider2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Vector3 curVelocity = playerRigidbody.velocity;
        curVelocity.x = horizVelocity;
        LayerMask mask = LayerMask.NameToLayer("Ground");
        //Draw ray below the player to see that the player is grounded
        isGrounded = Physics2D.Raycast(new Vector2(transform.position.x, (transform.position.y + boxCol.size.y / 2) + 0.1f), Vector2.down, boxCol.size.y + 4.3f);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded)
            {
                curVelocity.y = jumpPower * 2;

                //if the player has the jump power up allow them to doublejump
                if(hasDoubleJump)
                {
                    canDoubleJump = true;
                }
            } else if(canDoubleJump)
            {
                //if player jumped after first jump set don't allow them to jump again and update velocity
                canDoubleJump = false;
                curVelocity.y = jumpPower * 2;
            }
        }

        else if (curVelocity.y < 0 && !isGrounded)
        {
            //when y velocity is - and player is not ground trigger falling animation
            animator.SetBool("isFalling", true);
            animator.SetBool("isJumping", false);
        }
        else if (curVelocity.y > 0 && !isGrounded)
        {
            //when y velocity is + and player is grounded trigger jumping animation
            animator.SetBool("isJumping", true);
            animator.SetBool("isFalling", false);
        }
        else
        {
            //otherwise trigger running animation
            animator.SetBool("isJumping", false);
            animator.SetBool("isFalling", false);
        }

        //set the players velocity to the velocity from the jumping functionality
        playerRigidbody.velocity = curVelocity;
    }

    void OnCollisionEnter2D (Collision2D other) {
        if (other.collider.tag == "Ground")
        {
            isGrounded = true;
        }
    }

    void OnCollisionStay2D(Collision2D other) {
        if (other.collider.tag == "Ground")
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.collider.tag == "Ground")
        {
            isGrounded = false;
        }
    }

    //called by powerup trigger collider
    public void setDoubleJump(bool has)
    {
        hasDoubleJump = has;
        Debug.Log("Player can now double jump");
    }



}
