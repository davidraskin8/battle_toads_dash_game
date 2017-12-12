using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelector : MonoBehaviour {

    public SceneFader fader;

    public void Select(string name)
    {
        fader.FaidTo(name);
    }

}
