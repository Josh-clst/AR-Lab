using UnityEngine;
using UnityEngine.EventSystems;

public class Example : MonoBehaviour, IPointerClickHandler
{
    private bool isClicked = false;
    //Detect if a click occurs
    public void OnPointerClick(PointerEventData pointerEventData)
    {
        GameObject clickedObject = pointerEventData.pointerCurrentRaycast.gameObject;
        if (clickedObject != null)
        {
            Renderer rend = clickedObject.GetComponent<Renderer>();
            if (rend != null)
            {
                
                // Change the material color
                if (!isClicked) 
                {
                    rend.material.color = Color.black;
                    isClicked = true;
                }
                else 
                {
                    rend.material.color = Color.yellow;
                    isClicked = false;
                }
            }
        }
    }
}
