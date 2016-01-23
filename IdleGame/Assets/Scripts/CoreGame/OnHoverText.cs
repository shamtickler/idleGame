using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class OnHoverText : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler{

    public Vector3 offset;
    private Transform temp;

    public string resource1;
    public string resource2;
    public string resource3;
    public string resource4;

    public float cost1;
    public float cost2;
    public float cost3;
    public float cost4;

    void Start()
    {
        //Transform _setLocation = new Transform();
    }

    //code for when the mouse enters the element goes here
    public void OnPointerEnter(PointerEventData eventData)
    {
        ProductionController.gameControllerObject.GetComponent<HoverTextController>().Activate();

        ProductionController.gameControllerObject.GetComponent<HoverTextController>().ChangeDisplay(resource1, resource2, resource3, resource4, cost1, cost2, cost3, cost4);

        temp = gameObject.transform;
        temp.position += offset;
        ProductionController.gameControllerObject.GetComponent<HoverTextController>().SetLocation(temp);

    }

    //code for when the mouse exits the element goes here
    public void OnPointerExit(PointerEventData eventData)
    {
        ProductionController.gameControllerObject.GetComponent<HoverTextController>().DeActivate();

    }

}
