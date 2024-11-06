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
        // Get the object clicked on and its parent
        GameObject clickedObject = pointerEventData.pointerCurrentRaycast.gameObject;
        GameObject parent = clickedObject.transform.parent.gameObject;
        if (parent != null)
        {
            // Get all the renderers in the prefab and the text component to update
            Renderer[] rends = parent.GetComponentsInChildren<Renderer>();
            TMP_Text text = parent.GetComponentInChildren<TMP_Text>();

            // Update the text component
            nbClicks++;
            text.text = clickedObject.name + "\n" + "Nb of interactions: " + nbClicks;
            
            // Change the color of the object clicked on
            foreach (Renderer rend in rends) {
                if (rend != null)
                {
                    // Change the material color
                    if (!isClicked) 
                        rend.material.color = Color.black;
                    else 
                        rend.material.color = Color.yellow;
                }
            }
            // Change the state of the object clicked on (for the color change on the next click)
            isClicked = !isClicked;
        }
    }
}
