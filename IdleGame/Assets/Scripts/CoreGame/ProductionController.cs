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
        //controls how much wood is collectable
        collectableWoodAmmount = 50 + VillageController.carts * 50;

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
        VillageController.carts += 1;
        NF.AddNotification("With a cart villagers can collect more wood.");

    }//end BuildCart()

    public void BuildWoodCutters()
    {
        VillageController.woodCutters += 1;
        NF.AddNotification("The woodcutters shack will continue to produce wood for us.");
    }



    public void Purchase(string _item, string _resource1, string _resource2, string _resource3, string _resource4, float _cost1, float _cost2, float _cost3, float _cost4)
    {
        float canPurchase = 0;

        string[] resources = new string[4];
        resources[0] = _resource1;
        resources[1] = _resource2;
        resources[2] = _resource3;
        resources[3] = _resource4;

        float[] costs = new float[4];
        costs[0] = _cost1;
        costs[1] = _cost2;
        costs[2] = _cost3;
        costs[3] = _cost4;


        //check if the costs can be met
        for (int i = 0; i < resources.Length; i++)
        {

            if(resources[i] == "Cloth")
            {
                if (costs[i] > ResourceController.cloth)
                {
                    canPurchase += 1;
                    NF.AddNotification("I will need more cloth for that.");
                }
            }//end check for cloth

            if (resources[i] == "Coal")
            {
                if (costs[i] > ResourceController.coal)
                {
                    canPurchase += 1;
                    NF.AddNotification("I will need more coal for that.");

                }
            }//end check for coal

            if (resources[i] == "Flint")
            {
                if (costs[i] > ResourceController.flint)
                {
                    canPurchase += 1;
                    NF.AddNotification("I will need more flint for that.");

                }
            }//end check for flint

            if (resources[i] == "Food")
            {
                if (costs[i] > ResourceController.food)
                {
                    canPurchase += 1;
                    NF.AddNotification("I will need more food for that.");

                }
            }//end check for food

            if (resources[i] == "Fur")
            {
                if (costs[i] > ResourceController.fur)
                {
                    canPurchase += 1;
                    NF.AddNotification("I will need more fur for that.");

                }
            }//end check for fur

            if (resources[i] == "Iron")
            {
                if (costs[i] > ResourceController.iron)
                {
                    canPurchase += 1;
                    NF.AddNotification("I will need more iron for that.");

                }
            }//end check for iron

            if (resources[i] == "Leather")
            {
                if (costs[i] > ResourceController.leather)
                {
                    canPurchase += 1;
                    NF.AddNotification("I will need more leather for that.");

                }
            }//end check for leather

            if (resources[i] == "Meat")
            {
                if (costs[i] > ResourceController.meat)
                {
                    canPurchase += 1;
                    NF.AddNotification("I will need more meat for that.");

                }
            }//end check for meat

            if (resources[i] == "Scales")
            {
                if (costs[i] > ResourceController.scales)
                {
                    canPurchase += 1;
                    NF.AddNotification("I will need more scales for that.");

                }
            }//end check for scales

            if (resources[i] == "Stone")
            {
                if (costs[i] > ResourceController.stone)
                {
                    canPurchase += 1;
                    NF.AddNotification("I will need more stone for that.");

                }
            }//end check for stone

            if (resources[i] == "Wood")
            {
                if (costs[i] > ResourceController.wood)
                {
                    canPurchase += 1;
                    NF.AddNotification("I will need more wood for that.");

                }
            }//end check for wood

        }// end of checking resource values

        //
        //  IF THE RESOURCE REQUIREMENTS ARE MET, NEXT WE NEED TO SUBTRACT THOSE RESOURCES FROM THE COFFERS
        //

        if (canPurchase == 0)
        {
            //spend resources
            for (int i = 0; i < resources.Length; i++)
            {

                if (resources[i] == "Cloth")
                {
                    ResourceController.cloth -= costs[i];
                }//end check for cloth

                if (resources[i] == "Coal")
                {
                    ResourceController.coal -= costs[i];

                }//end check for coal

                if (resources[i] == "Flint")
                {
                    ResourceController.flint -= costs[i];

                }//end check for flint

                if (resources[i] == "Food")
                {
                    ResourceController.food -= costs[i];

                }//end check for food

                if (resources[i] == "Fur")
                {
                    ResourceController.fur -= costs[i];

                }//end check for fur

                if (resources[i] == "Iron")
                {
                    ResourceController.iron -= costs[i];

                }//end check for iron

                if (resources[i] == "Leather")
                {
                    ResourceController.leather -= costs[i];

                }//end check for leather

                if (resources[i] == "Meat")
                {
                    ResourceController.meat -= costs[i];

                }//end check for meat

                if (resources[i] == "Scales")
                {
                    ResourceController.scales -= costs[i];

                }//end check for scales

                if (resources[i] == "Stone")
                {
                    ResourceController.stone -= costs[i];

                }//end check for stone

                if (resources[i] == "Wood")
                {
                    ResourceController.wood -= costs[i];

                }//end check for wood

            }// end of checking resource values

            //
            //AFTER SUBTRACTING THE RESOURCES WE WANT TO ACTUALLY BUILD WHATEVER THE ITEM WAS
            //
            CheckPurchasedItem(_item);

        }//end of subtracting resources

        
    }

    public void CheckPurchasedItem(string _name)
    {
        if ((_name == "Cart"))
        {
            BuildCart();
        }

        if ((_name == "WoodCutters"))
        {
            BuildWoodCutters();
        }


    }//end checking purchaseName

}
