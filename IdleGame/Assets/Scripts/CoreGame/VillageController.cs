using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class VillageController : MonoBehaviour {

    public static float carts;
    public static float farms;
    public static float hunters;
    public static float ironMines;
    public static float quarries;
    public static float tannery;
    public static float woodCutters;


    [SerializeField]
    private Text cartsTitle;
    [SerializeField]
    private Text farmsTitle;
    [SerializeField]
    private Text huntersTitle;
    [SerializeField]
    private Text ironMinesTitle;
    [SerializeField]
    private Text quarriesTitle;
    [SerializeField]
    private Text tanneryTitle;
    [SerializeField]
    private Text woodCuttersTitle;


    [SerializeField]
    private Text cartsValue;
    [SerializeField]
    private Text farmsValue;
    [SerializeField]
    private Text huntersValue;
    [SerializeField]
    private Text ironMinesValue;
    [SerializeField]
    private Text quarriesValue;
    [SerializeField]
    private Text tanneryValue;
    [SerializeField]
    private Text woodCuttersValue;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


        //check carts values
        if (carts > 0)
        {
            cartsTitle.gameObject.SetActive(true);
        }
        else
        {
            cartsTitle.gameObject.SetActive(false);
        }

        //check farms values
        if (farms > 0)
        {
            farmsTitle.gameObject.SetActive(true);
        }
        else
        {
            farmsTitle.gameObject.SetActive(false);
        }

        //check hunters values
        if (hunters > 0)
        {
            huntersTitle.gameObject.SetActive(true);
        }
        else
        {
            huntersTitle.gameObject.SetActive(false);
        }


        //check ironMines values
        if (ironMines > 0)
        {
            ironMinesTitle.gameObject.SetActive(true);
        }
        else
        {
            ironMinesTitle.gameObject.SetActive(false);
        }


        //check quarries values
        if (quarries > 0)
        {
            quarriesTitle.gameObject.SetActive(true);
        }
        else
        {
            quarriesTitle.gameObject.SetActive(false);
        }


        //check farms values
        if (tannery > 0)
        {
            tanneryTitle.gameObject.SetActive(true);
        }
        else
        {
            tanneryTitle.gameObject.SetActive(false);
        }


        //check farms values
        if (woodCutters > 0)
        {
            woodCuttersTitle.gameObject.SetActive(true);
        }
        else
        {
            woodCuttersTitle.gameObject.SetActive(false);
        }

        //update all the village building values
        cartsValue.text = ((int)carts).ToString();
        farmsValue.text = ((int)farms).ToString();
        huntersValue.text = ((int)hunters).ToString();
        ironMinesValue.text = ((int)ironMines).ToString();
        quarriesValue.text = ((int)quarries).ToString();
        tanneryValue.text = ((int)tannery).ToString();
        woodCuttersValue.text = ((int)woodCutters).ToString();

    }//end Update()
}
