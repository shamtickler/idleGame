using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HoverTextController : MonoBehaviour {


    public GameObject hoverObject;

    [SerializeField]
    private Text resource1;
    [SerializeField]
    private Text resource2;
    [SerializeField]
    private Text resource3;
    [SerializeField]
    private Text resource4;

    [SerializeField]
    private Text cost1;
    [SerializeField]
    private Text cost2;
    [SerializeField]
    private Text cost3;
    [SerializeField]
    private Text cost4;


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ChangeDisplay(string _resource1, string _resource2, string _resource3, string _resource4, float _cost1, float _cost2, float _cost3, float _cost4)
    {
        resource1.text = _resource1;
        resource2.text = _resource2;
        resource3.text = _resource3;
        resource4.text = _resource4;

        cost1.text = ((int)_cost1).ToString();
        cost2.text = ((int)_cost2).ToString();
        cost3.text = ((int)_cost3).ToString();
        cost4.text = ((int)_cost4).ToString();
        //check if the text in resource1 is "null"
        if (resource1.text == "null")
        {
            resource1.gameObject.SetActive(false);
        }
        else
        {
            resource1.gameObject.SetActive(true);
        }

        if (resource2.text == "null")
        {
            resource2.gameObject.SetActive(false);
        }
        else
        {
            resource2.gameObject.SetActive(true);
        }

        if (resource3.text == "null")
        {
            resource3.gameObject.SetActive(false);
        }
        else
        {
            resource3.gameObject.SetActive(true);
        }

        if (resource4.text == "null")
        {
            resource4.gameObject.SetActive(false);
        }
        else
        {
            resource4.gameObject.SetActive(true);
        }

    }

    public void SetLocation(Transform _location)
    {
        hoverObject.transform.position = _location.position;
        //hoverObject.GetComponent<RectTransform>().
    }

    public void DeActivate()
    {
        hoverObject.SetActive(false);
    }

    public void Activate()
    {
        hoverObject.SetActive(true);
    }

}
