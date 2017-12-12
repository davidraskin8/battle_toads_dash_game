using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEnd : MonoBehaviour {

    public Canvas levelEndCanvas;
    void OnTriggerEnter2D(Collider2D other)
    {
        //Stop camera at end of level
        GameObject mainCamera = GameObject.Find("Main Camera");
        mainCamera.GetComponent<Follow>().enabled = false;

        //destroy the player since level is done
        Destroy(other.gameObject);

        //show the end of level canvas
        levelEndCanvas.gameObject.SetActive(true);

    }
}
