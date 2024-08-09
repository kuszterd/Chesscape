using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections.Generic;
using Unity.VisualScripting;

public class MoveHandler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public List<GameObject> pawnImages;
    
    public GameObject mainMove;
    
    private static bool isHoveringBaseImage;
    private static bool isHoveringAppearingImages;
    
    

    void Update()
    {
        if (!isHoveringBaseImage && !isHoveringAppearingImages)
        {
            SetAppearingImagesActive(false);
        }
        Debug.Log("Base: " + isHoveringBaseImage);
        Debug.Log("First: " + isHoveringAppearingImages);
        
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (eventData.pointerEnter == mainMove)
        {
            isHoveringBaseImage = true;
            SetAppearingImagesActive(true);
        }
        else if (eventData.pointerEnter == pawnImages[0] || eventData.pointerEnter == pawnImages[1])
        {
            isHoveringBaseImage = false;
            isHoveringAppearingImages = true;
            
        }
        else
        {
            isHoveringBaseImage = false; 
            isHoveringAppearingImages = false;
        }

    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (eventData.pointerEnter == mainMove)
        {
            isHoveringBaseImage = false;
            
        }
        else if (eventData.pointerEnter == pawnImages[0] || eventData.pointerEnter == pawnImages[1])
        {
            isHoveringBaseImage = false;
            isHoveringAppearingImages = false;
        }
        else
        {
            isHoveringBaseImage = false;  
            isHoveringAppearingImages = false;
        }

    }

    private void SetAppearingImagesActive(bool active)
    {
        foreach (GameObject image in pawnImages)
        {
            image.SetActive(active);
        }
    }

   


}
