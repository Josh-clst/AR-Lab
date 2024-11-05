using UnityEngine;
using UnityEngine.EventSystems;

public class Example : MonoBehaviour, IPointerClickHandler
{
    //Detect if a click occurs
    public void OnPointerClick(PointerEventData pointerEventData)
    {
        Ray ray = Camera.main.ScreenPointToRay(pointerEventData.position);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            GameObject clickedObject = hit.transform.gameObject;
            Renderer rend = clickedObject.GetComponent<Renderer>();
            if (rend != null)
            {
                // Change the material color
                if (rend.material.color == Color.yellow)
                    rend.material.color = Color.black;
                else
                    rend.material.color = Color.yellow;
            }
        }
    }
}
