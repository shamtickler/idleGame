using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ProductionController : MonoBehaviour {


    public Button collectWoodButton;
    public Slider collectWoodSlider;


    private float collectWoodTimer;

	// Use this for initialization
	void Start () {
        collectWoodTimer = 0;
        collectWoodButton.interactable = true;
        collectWoodSlider.value = collectWoodTimer;
	}
	
	// Update is called once per frame
	void Update () {
        //controls if "collectWood" button is available for use
        collectWoodSlider.value = collectWoodTimer;
        if (collectWoodTimer <= 0)
        {
            collectWoodButton.interactable = true;
        }
        else
        {
            collectWoodTimer -= Time.deltaTime;
        }
    }

    public void CollectWood()
    {
        ResourceController.wood += 50;
        collectWoodButton.interactable = false;
        collectWoodTimer = 10;
        gameObject.GetComponent<NotificationFeed>().AddNotification("Some villagers scavanged a couple branches and twigs.");
    }
}
