using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PopupController : MonoBehaviour {

    public GameObject eventControllers;

    [SerializeField]
    private float minEventTimer = 30f;
    private float timeSinceLastEvent;
    private float timeToWaitForEvent;
    private int numberOfDifferentEvents = 4;

    public GameObject eventCanvas;

    public Text aggresiveOption;
    public Text passiveOption;
    public Text curiousOption;
    public Text doNothingOption;

    public Text popupDescription;

    private int instanceNumber;

    private NotificationFeed NF;
    private ResourceController RC;


    // Use this for initialization
    void Start () {
        eventCanvas.SetActive(false);
        NF = gameObject.GetComponent<NotificationFeed>();
        RC = gameObject.GetComponent<ResourceController>();
        timeToWaitForEvent = Random.Range(minEventTimer, minEventTimer + 90);
	}
	
	// Update is called once per frame
	void Update () {
        //count how long it has been since the last random event
        timeSinceLastEvent += Time.deltaTime;
        //if that time equals the time defined then it is time for another random event!
        if (timeSinceLastEvent >= timeToWaitForEvent)
        {
            StartRandomEvent();
            timeSinceLastEvent = 0;
            timeToWaitForEvent = Random.Range(minEventTimer, minEventTimer + 90);
        }

	}

    public void StartRandomEvent()
    {
        //make sure the canvas is actually visable
        eventCanvas.SetActive(true);
        //here we select the random event and activate it
        instanceNumber = Random.Range(0, numberOfDifferentEvents);

        if ( instanceNumber == 0)
        {
            FogAndRaiders();
        }else if(instanceNumber == 1)
        {
            ChildBurnsDownWoodcutters();
        }
        else if (instanceNumber == 2)
        {
            string _animal = "Bear";
            AnimalAttack(_animal);
        }
        else if (instanceNumber == 3)
        {
            int n = Random.Range(1, 15);
            TraverlersToJoinVillage(n);
        }


    }

    //different selectable options
    public void SelectAggresiveOption()
    {
        eventCanvas.SetActive(false);

        if (instanceNumber == 0)
        {
            //Fog and bandits
            if (ResourceController.iron > 0)
            {
                NF.AddNotification("You grab a sword and run out of your hut swinging madly. You strike one of your own in the dense fog. As the fog lifts you gaze upon what you have done and resolve to blame this death on wild animals. Hopefully nobody saw what really happened");
                RC.SubtractResource("Iron", 10);
                RC.SubtractResource("Food", 20);
                RC.SubtractResource("Wood", 50);
                RC.AddResource("Meat", 5);

            }
            else
            {
                NF.AddNotification("You grab a walking stick and run out of your hut swinging madly. After a while the sounds abate and you see a family has had their home robbed");
                RC.SubtractResource("Furs", 10);
                RC.SubtractResource("Food", 30);
                RC.SubtractResource("Wood", 120);

            }
        }
        else if (instanceNumber == 1)
        {
            
        }
        else if (instanceNumber == 2)
        {
            
        }
        else if (instanceNumber == 3)
        {
            
        }
    }

    public void SelectPassiveOption()
    {
        eventCanvas.SetActive(false);

        if (instanceNumber == 0)
        {
            NF.AddNotification("From the light of the lantern peircing the thick veil of fog you witness 5 men dressed in leaves break down the door to a hut. After a short time inside they run of with some things from inside");
            RC.SubtractResource("Food", 35);
            RC.SubtractResource("Fur", 20);


        }
        else if (instanceNumber == 1)
        {

        }
        else if (instanceNumber == 2)
        {

        }
        else if (instanceNumber == 3)
        {

        }
    }

    public void SelectCuriousOption()
    {
        eventCanvas.SetActive(false);

        if (instanceNumber == 0)
        {
            NF.AddNotification("You run outside into the dense fog and awaken with a bump on your head. The villagers say you ran into a tree while a hut was robbed by strange men");
            RC.SubtractResource("Iron", 10);
            RC.SubtractResource("Food", 100);
            RC.SubtractResource("Wood", 250);

        }
        else if (instanceNumber == 1)
        {

        }
        else if (instanceNumber == 2)
        {

        }
        else if (instanceNumber == 3)
        {

        }
    }

    public void SelectNothingOption()
    {
        eventCanvas.SetActive(false);

        if (instanceNumber == 0)
        {
            NF.AddNotification("The next morning you awake and find a hut has been robbed by strange men. The villagers wonder how you sleep so soundly");
            RC.SubtractResource("Wood", 350);
            RC.SubtractResource("Food", 200);
            RC.SubtractResource("Fur", 65);
            RC.SubtractResource("Flint", 10);


        }
        else if (instanceNumber == 1)
        {

        }
        else if (instanceNumber == 2)
        {

        }
        else if (instanceNumber == 3)
        {

        }
    }


    //different random events
    public void FogAndRaiders()
    {
        popupDescription.text = "You awken to sounds of wood splintering and metal scraping metal. A quick glance outside yields nothing but knowlege of a thick fog blanketing the village.";

        aggresiveOption.text = "Grab a weapon and swing at anything that moves";
        passiveOption.text = "Stay inside but keep watch";
        curiousOption.text = "Rush outside to see whats going on";
        doNothingOption.text = "Go back to sleep";

    }

    public void ChildBurnsDownWoodcutters()
    {
        popupDescription.text = "Child burns down woodcutters hut";

        aggresiveOption.text = "";
        passiveOption.text = "";
        curiousOption.text = "";
        doNothingOption.text = "";
    }

    public void AnimalAttack(string _animal)
    {
        popupDescription.text = "A " + _animal + " attacks";

        aggresiveOption.text = "";
        passiveOption.text = "";
        curiousOption.text = "";
        doNothingOption.text = "";
    }

    public void TraverlersToJoinVillage(int _travelers)
    {
        popupDescription.text = "A caravan of " + _travelers + " arrives at the entrance to the village seaking refuge";

        aggresiveOption.text = "";
        passiveOption.text = "";
        curiousOption.text = "";
        doNothingOption.text = "";
    }


}
