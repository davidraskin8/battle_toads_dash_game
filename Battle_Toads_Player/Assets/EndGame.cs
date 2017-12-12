using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour {


	//// Update is called once per frame
	//void Update () {
 //       if(Input.GetKeyDown(KeyCode.Escape))
	//	    if(canvas.gameObject.activeInHierarchy == false)
 //           {
 //               canvas.gameObject.SetActive(true);
 //               Time.timeScale = 0;
 //           } else
 //           {
 //               canvas.gameObject. SetActive(false);
 //               Time.timeScale = 1;
 //           }
	//}

    public void StopGame()
    {
        Transform canvas = GameObject.Find("End Canvas Parent").transform.GetChild(0);
        Debug.Log("Game Stopped");
        canvas.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
}
