using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneFader : MonoBehaviour
{

    public Image image;
    public AnimationCurve curve;

    void Start ()
    {
        StartCoroutine(FadeIn());
    }

    //
    public void FaidTo(string sceneName)
    { 
        //If the game is paused from a pause menu, unpause so that Update can be called
        if(Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }

        StartCoroutine(FadeOut(sceneName));
    }

    //IEnumerator runs across multiple frames

    //Go from 1 aplha to 0 alpha level to fade into the scene
    IEnumerator FadeIn()
    {
        float t = 1f;

        while (t > 0f)
        {
            t -= Time.deltaTime;

            //use animation curve for non-constant fading
            float a = curve.Evaluate(t);
            image.color = new Color(0f, 0f, 0f, a);

            //pass the frame
            yield return 0;
        }
    }

    //Go from 0 alpha to 1 alpha level to fade out of the scene
    IEnumerator FadeOut(string scene)
    {
        float t = 0f;

        while (t < 1f)
        {
            t += 4*Time.deltaTime;
            float a = curve.Evaluate(t);
            image.color = new Color(0f, 0f, 0f, a);
            yield return 0;
        }

        SceneManager.LoadScene(scene);
    }
}