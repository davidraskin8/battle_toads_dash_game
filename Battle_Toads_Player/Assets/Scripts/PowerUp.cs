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
        if (_player.GetComponent<PlayerScript>() != null)
        {
            PlayerScript playerScript = _player.GetComponent<PlayerScript>();
            playerScript.setDoubleJump(true);

            PowerupUI uiScript = powerUpPanel.GetComponent<PowerupUI>();
            uiScript.InstantiatePowerUp(toInstantiate, powerUpTime);

            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<BoxCollider2D>().enabled = false;

            yield return new WaitForSeconds(powerUpTime);

            playerScript.setDoubleJump(false);

            uiScript.DestroyPowerUp();
        }
        else if (_player.GetComponent<ChickenScript>() != null)
        {
            ChickenScript playerScript = _player.GetComponent<ChickenScript>();
            playerScript.setDoubleJump(true);

            PowerupUI uiScript = powerUpPanel.GetComponent<PowerupUI>();
            uiScript.InstantiatePowerUp(toInstantiate, powerUpTime);

            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<BoxCollider2D>().enabled = false;

            yield return new WaitForSeconds(powerUpTime);

            playerScript.setDoubleJump(false);

            uiScript.DestroyPowerUp();
        }



        Destroy(gameObject);
    }
}
