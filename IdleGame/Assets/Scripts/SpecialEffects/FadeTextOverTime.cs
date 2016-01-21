using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent (typeof (Text))]
public class FadeTextOverTime : MonoBehaviour {

    [SerializeField]
    private float fadeTime = 30;

    private float currentFadeTime;
    private Color temp;

	// Use this for initialization
	void Start () {
        currentFadeTime = fadeTime;
	}
	
	// Update is called once per frame
	void Update () {
        temp = gameObject.GetComponent<Text>().color;
        temp.a = (currentFadeTime) / fadeTime;
        gameObject.GetComponent<Text>().color = temp;
        currentFadeTime -= Time.deltaTime;

        if (currentFadeTime < 0)
        {
            Destroy(gameObject);
        }
    }
}
