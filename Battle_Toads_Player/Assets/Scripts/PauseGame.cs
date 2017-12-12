using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour {
    public Transform canvas;

	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.Escape))
		    if(canvas.gameObject.activeInHierarchy == false)
            {
                //activate pause canvas and stop time
                Pause();
            } else
            {
                //deactivate pause canvas and start time
                Resume();
            }
	}

    public void Resume()
    {
        canvas.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void Pause()
    {
        canvas.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
}
