using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Scary01Close : MonoBehaviour, IPointerClickHandler
{
    public Canvas tutorialCanvas;

    public void OnPointerClick(PointerEventData eventData)
    {
        tutorialCanvas.gameObject.SetActive(false);
        tutorialCanvas.GetComponent<Canvas>().enabled = false;
        Time.timeScale = 1f;
        
    }

}
