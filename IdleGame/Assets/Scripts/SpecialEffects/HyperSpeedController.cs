using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HyperSpeedController : MonoBehaviour {
    [HideInInspector]
    public bool hyperspeed = false;
    [SerializeField]
    private Text hyperText;


    public void ToggleHyperspeed()
    {
        if (hyperspeed == false)
        {
            hyperspeed = true;
            Time.timeScale = 5.0f;
            hyperText.text = "Classic";
        }
        else
        {
            hyperspeed = false;
            Time.timeScale = 1;
            hyperText.text = "Hyper";
        }
    }
}
