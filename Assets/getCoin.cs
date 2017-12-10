using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//collecting coins
public class getCoin : MonoBehaviour {
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //increment score by 1
        PlayerClass.playerScore++;
        //destroy coin
        Destroy(collision.gameObject);
    }
}
