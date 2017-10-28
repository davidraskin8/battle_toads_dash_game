using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    public float jumpPower = 10.0f;
    Rigidbody2D playerRigidbody;
    bool isGrounded = false;

	// Use this for initialization
	void Start () {
        playerRigidbody = transform.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetKey(KeyCode.Space) && isGrounded) {
            playerRigidbody.AddForce(Vector3.up * (jumpPower * playerRigidbody.mass * playerRigidbody.gravityScale * 20.0f));
        }
	}

    void OnCollisionEnter2D (Collision2D other) {
        if (other.collider.tag == "Ground") {
            Debug.Log("Yayayyayay");
            isGrounded = true;
        }
    }

    void OnCollisionStay2D(Collision2D other) {
        if (other.collider.tag == "Ground") {
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
}
