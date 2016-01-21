using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ResourceController : MonoBehaviour {

    public static float cloth;
    public static float coal;
    public static float flint;
    public static float food;
    public static float fur;
    public static float iron;
    public static float leather;
    public static float meat;
    public static float scales;
    public static float stone;
    public static float wood;



    [SerializeField]
    private Text clothTitle;
    [SerializeField]
    private Text coalTitle;
    [SerializeField]
    private Text flintTitle;
    [SerializeField]
    private Text foodTitle;
    [SerializeField]
    private Text furTitle;
    [SerializeField]
    private Text ironTitle;
    [SerializeField]
    private Text leatherTitle;
    [SerializeField]
    private Text meatTitle;
    [SerializeField]
    private Text scalesTitle;
    [SerializeField]
    private Text stoneTitle;
    [SerializeField]
    private Text woodTitle;

    [SerializeField]
    private Text clothValue;
    [SerializeField]
    private Text coalValue;
    [SerializeField]
    private Text flintValue;
    [SerializeField]
    private Text foodValue;
    [SerializeField]
    private Text furValue;
    [SerializeField]
    private Text ironValue;
    [SerializeField]
    private Text leatherValue;
    [SerializeField]
    private Text meatValue;
    [SerializeField]
    private Text scalesValue;
    [SerializeField]
    private Text stoneValue;
    [SerializeField]
    private Text woodValue;


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //check cloth values
	    if (cloth > 0)
        {
            clothTitle.gameObject.SetActive(true);
        }
        else
        {
            clothTitle.gameObject.SetActive(false);
        }
        //check coal value
        if (coal > 0)
        {
            coalTitle.gameObject.SetActive(true);
        }
        else
        {
            coalTitle.gameObject.SetActive(false);
        }
        //check flint values
        if (flint > 0)
        {
            flintTitle.gameObject.SetActive(true);
        }
        else
        {
            flintTitle.gameObject.SetActive(false);
        }
        //check food values
        if (food > 0)
        {
            foodTitle.gameObject.SetActive(true);
        }
        else
        {
            foodTitle.gameObject.SetActive(false);
        }
        //check fur values
        if (fur > 0)
        {
            furTitle.gameObject.SetActive(true);
        }
        else
        {
            furTitle.gameObject.SetActive(false);
        }
        //check iron values
        if (iron > 0)
        {
            ironTitle.gameObject.SetActive(true);
        }
        else
        {
            ironTitle.gameObject.SetActive(false);
        }
        //check leather values
        if (leather > 0)
        {
            leatherTitle.gameObject.SetActive(true);
        }
        else
        {
            leatherTitle.gameObject.SetActive(false);
        }
        //check meat values
        if (meat > 0)
        {
            meatTitle.gameObject.SetActive(true);
        }
        else
        {
            meatTitle.gameObject.SetActive(false);
        }
        //check scales value
        if (scales > 0)
        {
            scalesTitle.gameObject.SetActive(true);
        }
        else
        {
            scalesTitle.gameObject.SetActive(false);
        }
        //check stone value
        if (stone > 0)
        {
            stoneTitle.gameObject.SetActive(true);
        }
        else
        {
            stoneTitle.gameObject.SetActive(false);
        }
        //check wood value
        if (wood > 0)
        {
            woodTitle.gameObject.SetActive(true);
        }
        else
        {
            woodTitle.gameObject.SetActive(false);
        }

        //update all the value texts
        clothValue.text = ((int)cloth).ToString();
        coalValue.text = ((int)coal).ToString();
        flintValue.text = ((int)flint).ToString();
        foodValue.text = ((int)food).ToString();
        furValue.text = ((int)fur).ToString();
        ironValue.text = ((int)iron).ToString();
        leatherValue.text = ((int)leather).ToString();
        meatValue.text = ((int)meat).ToString();
        scalesValue.text = ((int)scales).ToString();
        stoneValue.text = ((int)stone).ToString();
        woodValue.text = ((int)wood).ToString();


    }//end of Update()
}
