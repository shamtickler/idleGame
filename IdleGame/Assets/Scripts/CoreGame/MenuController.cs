using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuController : MonoBehaviour {

    //public AnimationClip fadeInCabin;
    //public AnimationClip fadeOutCabin;

    //public float animationspeed;

    public Canvas kingsCabin;
    public Canvas village;

    private bool cabinActive = true;
    private bool villageActive = false;

	// Use this for initialization
	void Start () {
        //set king's cabin as home screen
        kingsCabin.GetComponent<CanvasGroup>().alpha = 1;
        kingsCabin.gameObject.SetActive(true);
        //hide all other screens
        village.GetComponent<CanvasGroup>().alpha = 1;
        village.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update () {
	
        
	}

    public void GoToVillage()
    {
        //kingsCabin.GetComponent<Animation>().Play("FadeOut");
        kingsCabin.gameObject.SetActive(false);
        village.gameObject.SetActive(true);
    }

    public void GoToKingsCabin()
    {
        kingsCabin.gameObject.SetActive(true);
        village.gameObject.SetActive(false);
    }


}
