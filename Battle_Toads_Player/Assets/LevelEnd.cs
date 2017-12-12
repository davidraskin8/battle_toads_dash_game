using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEnd : MonoBehaviour {

    public Canvas levelEndCanvas;
    void OnTriggerEnter2D(Collider2D other)
    {
        GameObject mainCamera = GameObject.Find("Main Camera");
        mainCamera.GetComponent<Follow>().enabled = false;

        Destroy(other.gameObject);

        levelEndCanvas.gameObject.SetActive(true);

    }
}
