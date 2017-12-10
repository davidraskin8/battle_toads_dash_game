using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//GameControl refers to class that contains player controls and behavior
public class triangleobstacle : MonoBehaviour {
    private void OnTriggerEnter2D(Collider2D collision)
    {

        //If player hits obstacle, game over
        if (collision.GetComponent<player>() = null)
            GameControl.instance.PlayerDied();
    }
