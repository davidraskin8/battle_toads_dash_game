using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killer : MonoBehaviour {

    public Transform playerTransform;
    public Transform respawnPoint;

    private GameObject controller;


    void OnTriggerEnter2D(Collider2D other)
    {
        GameObject mainCamera = GameObject.Find("Main Camera");
        mainCamera.GetComponent<Follow>().enabled = false;

        Rigidbody2D playerRB = other.gameObject.GetComponent<Rigidbody2D>();
        other.gameObject.GetComponent<BoxCollider2D>().enabled = false;

        if (other.gameObject.GetComponent<AnimalScript>() != null)
        {
            other.gameObject.GetComponent<AnimalScript>().enabled = false;
        }

        playerRB.gravityScale = 0;
        playerRB.velocity = new Vector2(0, 1);
        
        controller = GameObject.Find("GameController");
        controller.GetComponent<EndGame>().StopGame();

    }
}
