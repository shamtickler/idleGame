using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class OnHoverFill : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{

    [SerializeField]
    private Slider fill;

    private bool isFilled = false;


    // Update is called once per frame
    void Update()
    {
        if (isFilled == true && fill.value < 10)
        {
            fill.value += Time.unscaledDeltaTime * 75;

        }
        else if (isFilled == false && fill.value > 0)
        {
            fill.value -= Time.unscaledDeltaTime * 75;

        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isFilled = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isFilled = false;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        isFilled = false;
        fill.value = 0;
    }
}
