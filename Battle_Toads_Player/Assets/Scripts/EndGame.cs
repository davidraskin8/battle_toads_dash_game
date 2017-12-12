using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour {


    public void StopGame()
    {
        //Called on player death

        //show the Death Canvas
        Transform canvas = GameObject.Find("End Canvas Parent").transform.GetChild(0);
        Debug.Log("Game Stopped");
        canvas.gameObject.SetActive(true);
        Time.timeScale = 0;

    }
}
