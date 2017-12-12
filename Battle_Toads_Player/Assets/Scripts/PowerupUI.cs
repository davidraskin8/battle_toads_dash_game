using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupUI : MonoBehaviour {

    GameObject powerUp;

    public void InstantiatePowerUp (GameObject img, float duration)
    {
        //instantiate the power up image in this panel
        powerUp = Instantiate(img, gameObject.transform);
    }

    public void DestroyPowerUp()
    {
        //destroy the image in this panel
        Destroy(powerUp);
        Debug.Log("power Up destroyed");
    }
}