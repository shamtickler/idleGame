using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NotificationFeed : MonoBehaviour {

    public GameObject notificationPrefab;
    [SerializeField]
    private GameObject parentObject;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void AddNotification(string _notificationText)
    {
        GameObject temp = Instantiate(notificationPrefab);
        temp.GetComponent<Text>().text = _notificationText;
        temp.transform.parent = parentObject.transform;
        temp.transform.SetSiblingIndex(0);
    }

}
