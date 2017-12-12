using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour {

    public float powerUpTime = 0.05f;
    GameObject powerUpPanel;
    public GameObject toInstantiate;

    void Start()
    {
       powerUpPanel = GameObject.Find("Powerup Panel");
        Debug.Log(powerUpPanel);
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        GameObject player;
        if (other.CompareTag("Player"))
        {
            player = other.gameObject;
            StartCoroutine(PickUp(player));
        }
    }

    IEnumerator PickUp(GameObject _player)
    {   
        
        Debug.Log("Power up picked up");

        if (_player.GetComponent<AnimalScript>() != null)
        {
            AnimalScript playerScript = _player.GetComponent<AnimalScript>();

            //allow the player to double jump
            playerScript.setDoubleJump(true);

            //inistantiate the powerup image in the panel with the PowerupUI script
            PowerupUI uiScript = powerUpPanel.GetComponent<PowerupUI>();
            uiScript.InstantiatePowerUp(toInstantiate, powerUpTime);

            //disable collision and rendering of the powerup
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<BoxCollider2D>().enabled = false;

            //the player only has the power up for a certain amount of time
            yield return new WaitForSeconds(powerUpTime);

            playerScript.setDoubleJump(false);

            //destroy the powerup
            uiScript.DestroyPowerUp();
        }


        //Destroy the powerup
        Destroy(gameObject);
    }
}
