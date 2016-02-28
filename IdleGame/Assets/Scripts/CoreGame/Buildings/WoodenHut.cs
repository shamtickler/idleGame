using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class WoodenHut : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private float delayTime;
    public float startingDelayTime = 5;
    public string purchaseName;

    public string resource1;
    public string resource2;
    public string resource3;
    public string resource4;

    public float cost1;
    public float cost2;
    public float cost3;
    public float cost4;


    // Use this for initialization
    void Awake()
    {
        delayTime = startingDelayTime;

    }

    // Update is called once per frame
    void Update()
    {
        cost1 = 700 + 100 * VillageController.woodenHuts;
        cost2 = 30 + 10 * VillageController.woodenHuts;


    }

    //code for when the mouse enters the element goes here
    public void OnPointerEnter(PointerEventData eventData)
    {
        UpdatePricingText();
        ProductionController.gameControllerObject.GetComponent<HoverTextController>().Activate();
        ProductionController.gameControllerObject.GetComponent<HoverTextController>().SetLocation(gameObject.transform);


    }

    public void UpdatePricingText()
    {

        ProductionController.gameControllerObject.GetComponent<HoverTextController>().ChangeDisplay(resource1, resource2, resource3, resource4, cost1, cost2, cost3, cost4);


    }



    //code for when the mouse exits the element goes here
    public void OnPointerExit(PointerEventData eventData)
    {
        ProductionController.gameControllerObject.GetComponent<HoverTextController>().DeActivate();

    }

    public void Buy()
    {
        ProductionController.gameControllerObject.GetComponent<ProductionController>().Purchase(purchaseName, resource1, resource2, resource3, resource4, cost1, cost2, cost3, cost4);
        ProductionController.gameControllerObject.GetComponent<HoverTextController>().DeActivate();

        UpdatePricingText();
    }


}
