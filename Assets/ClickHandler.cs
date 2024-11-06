using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class Example : MonoBehaviour, IPointerClickHandler
{   
    private int nbClicks = 0;
    private bool isClicked = false;
    //Detect if a click occurs
    public void OnPointerClick(PointerEventData pointerEventData)
    {
        GameObject clickedObject = pointerEventData.pointerCurrentRaycast.gameObject;
        GameObject parent = clickedObject.transform.parent.gameObject;
        if (parent != null)
        {
            Renderer[] rends = parent.GetComponentsInChildren<Renderer>();
            TMP_Text text = parent.GetComponentInChildren<TMP_Text>();
            nbClicks++;
            text.text = clickedObject.name + "\n" + "Nb of interactions: " + nbClicks;
            foreach (Renderer rend in rends) {
                if (rend != null)
                {
                    // Change the material color
                    if (!isClicked) 
                    {
                        rend.material.color = Color.black;
                    }
                    else 
                    {
                        rend.material.color = Color.yellow;
                    }
                }
            }
            isClicked = !isClicked;
        }
    }
}
