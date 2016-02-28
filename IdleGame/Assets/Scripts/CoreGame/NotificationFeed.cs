using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NotificationFeed : MonoBehaviour {

    public GameObject notificationPrefab;
    [SerializeField]
    private GameObject parentObject;

    [SerializeField]
    private float momentOfSilenceMax = 20;
    private float momentOfSilenceTime = 0;

    private string[] directions;

	// Use this for initialization
	void Start () {
        momentOfSilenceTime = 0;

        directions = new string[8];
        directions[0] = "north";
        directions[4] = "northeast";
        directions[1] = "east";
        directions[5] = "southeast";
        directions[2] = "south";
        directions[6] = "southwest";
        directions[3] = "west";
        directions[7] = "nothwest";


    }

    // Update is called once per frame
    void Update () {
        //add to timer, if it reaches max then a notification is made about something.
        momentOfSilenceTime += Time.deltaTime;
        if (momentOfSilenceTime > momentOfSilenceMax)
        {
            float rndTemp = Random.Range(0, 100);
            //do something depending on the random number
            if (rndTemp < 10)
            {
                AddNotification("Small animals skitter across the forest floor.");
            } else if (rndTemp < 20 && rndTemp >= 10)
            {
                int rndDir = Random.Range(0, 7);
                AddNotification("A thick fog begins to roll in from the " + directions[rndDir] + ".");
            } else if (rndTemp < 30 && rndTemp >= 20)
            {
                AddNotification("The air is earily quiet.");
            }else if (rndTemp < 40 && rndTemp >= 30)
            {
                AddNotification("Rain drizzles down for hours.");
            }else if (rndTemp < 50 && rndTemp >= 40)
            {
                int rndDir = Random.Range(0, 7);
                AddNotification("The wind blows from the " + directions[rndDir] + ".");
            }
            else if (rndTemp < 60 && rndTemp >= 50)
            {
                int rndDir = Random.Range(0, 7);
                AddNotification("The wind blows from the " + directions[rndDir] + ".");
            }
            else if (rndTemp < 70 && rndTemp >= 60)
            {
                AddNotification("The sun is shining brightly through the trees");
            }else if (rndTemp < 80 && rndTemp >= 70)
            {
                AddNotification("You hear the crack of an axe in wood.");
            }else if (rndTemp < 90 && rndTemp >= 80)
            {
                int rndDir = Random.Range(0, 7);
                AddNotification("From the  " + directions[rndDir] + " you see some nomads in the distance.");
            }
            else if (rndTemp <= 100 && rndTemp >= 90)
            {
                int rndDir = Random.Range(0, 3);
                AddNotification("The stars seem brightest in the   " + directions[rndDir] + ".");
            }

        }//end of random silence breaker
	


	}

    public void AddNotification(string _notificationText)
    {
        GameObject temp = Instantiate(notificationPrefab);
        temp.GetComponent<Text>().text = " - " + _notificationText;
        //temp.transform.parent = parentObject.transform;
        temp.transform.SetParent(parentObject.transform);
        temp.transform.SetSiblingIndex(0);

        momentOfSilenceTime = 0;
    }

}
