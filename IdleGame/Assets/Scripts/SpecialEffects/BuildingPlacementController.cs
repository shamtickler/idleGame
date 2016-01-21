using UnityEngine;
using System.Collections;

public class BuildingPlacementController : MonoBehaviour {

    public GameObject startingPoint;
    
    [HideInInspector]
    public Sprite[] buildingSprites;

	// Use this for initialization
	void Awake () {
        // load all frames in buildingSprites array
        buildingSprites = Resources.LoadAll<Sprite>("Buildings");
    }

    void Start()
    {

    }
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKeyDown(KeyCode.P))
        {
            //create the object
            GameObject building = new GameObject();
            building.transform.position = startingPoint.transform.position;

            //add a "spriteRenderer component to the new object
            building.AddComponent<SpriteRenderer>();
            //assign a random building image from the buildingSprites array
            building.GetComponent<SpriteRenderer>().sprite = buildingSprites[(int)Random.Range(0, 100)];
            //startingPoint.transform.position
        }
	}
}
