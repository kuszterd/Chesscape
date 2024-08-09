using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveSequenceHelper : MonoBehaviour
{

    public List<MoveSetup> moveSequenceImages;
    private int numberOfMove = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    

    public void AddMoveSequence()
    {
        moveSequenceImages[numberOfMove].gameObject.SetActive(true);
        Image getImage = gameObject.GetComponent<Image>();
        Image targetImage = moveSequenceImages[numberOfMove].GetComponent<Image>();
        MoveSetup moveSetup = gameObject.GetComponent<MoveSetup>();
        MoveSetup targetSetup = moveSequenceImages[numberOfMove].GetComponent<MoveSetup>();
        targetImage.sprite = getImage.sprite;
        targetImage.color = getImage.color;

        if (moveSetup == null)
        {
            Debug.LogError("MoveSetup component is missing on the source object.");
            return;
        }

        if (targetSetup == null)
        {
            Debug.LogError("MoveSetup component is missing on the target object.");
            return;
        }

        targetSetup.CopyFrom(moveSetup);
        

        numberOfMove++;
    }

    public void DeleteMoveSequence()
    {
        if(numberOfMove > 0)
        {
            numberOfMove--;
        }        
        moveSequenceImages[numberOfMove].gameObject.SetActive(false);
    }


    //private void Update()
    //{
    //    if (isMoving)
    //    {
    //        // Smoothly move the player towards the target position
    //        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * moveSpeed);

    //        // Check if close enough to the target position
    //        if (Vector3.Distance(transform.position, targetPosition) < 0.01f)
    //        {
    //            // Ensure the y position is set to the constant height
    //            transform.position = new Vector3(targetPosition.x, height, targetPosition.z);
    //            position = transform.position;
    //            squareName = PlayerMovement.Instance.GetSquareName(transform.position);

    //            isMoving = false;
    //        }
    //    }
    //}

    //public void MoveTo(Vector3 newPosition)
    //{
    //    targetPosition = new Vector3(newPosition.x, height, newPosition.z);
    //    isMoving = true;
    //}

    //public void PawnMove()
    //{

    //    Vector3 newPosition = position + new Vector3(0, 0, 1);
    //    MoveTo(newPosition);
    //}
}
