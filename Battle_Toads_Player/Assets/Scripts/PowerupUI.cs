using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupUI : MonoBehaviour {

    GameObject powerUp;

    public void InstantiatePowerUp (GameObject img, float duration)
    {
        powerUp = Instantiate(img, gameObject.transform);
    }

    public void DestroyPowerUp()
    {
        Destroy(powerUp);
        Debug.Log("power Up destroyed");
    }
}