using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_counter : MonoBehaviour {
    public Transform playerTransform;
    private GameController controller;

    void Start()
    {
        controller = GameObject.Find("GameController").GetComponent<GameController>();
    }

    public void OnTriggerEnter2D(Collider2D playerCollider)
    {
        //use the controller to add score when a coin is collided with
        controller.AddScore();
        Destroy(this.gameObject);

    }
}
