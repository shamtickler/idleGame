using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ProductionController : MonoBehaviour {

    public static GameObject gameControllerObject;

    public Button collectWoodButton;
    public Slider collectWoodSlider;
    public float collectableWoodAmmount;
    

    private float collectWoodTimer;
    private NotificationFeed NF;






	// Use this for initialization
	void Start () {
        gameControllerObject = gameObject;
        NF = gameObject.GetComponent<NotificationFeed>();
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
        ResourceController.wood += collectableWoodAmmount;
        collectWoodButton.interactable = false;
        collectWoodTimer = 10;
        NF.AddNotification("Some villagers scavanged a couple branches and twigs.");
    }

    public void BuildCart()
    {
        if (ResourceController.wood >= 200)
        {
            ResourceController.wood -= 200;
            collectableWoodAmmount += 100;
            NF.AddNotification("With a cart villagers can collect more wood.");
        }
        else
        {
            NF.AddNotification("With more wood I could build a cart.");
        }
    }//end BuildCart()


    public void Purchase(string _item)
    {
        if (_item == "Cart")
        {
            BuildCart();
        }
    }

}
