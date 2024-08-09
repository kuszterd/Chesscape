using UnityEngine;
using System.Linq;
using System.Collections.Generic;

public class ChessBoard : MonoBehaviour
{
    public List<ChessSquare> squares; // Array to hold all chessboard squares

    public GameObject keyFragmentPrefab;
    public GameObject wallPrefab;
    public GameObject playerPrefab;
    // Dictionary to store original colors of the squares
    private Dictionary<ChessSquare, Color> originalColors = new Dictionary<ChessSquare, Color>();

    private void Start()
    {
        InitializeBoard();
        UpdateSquareVisuals();
    }

    private void InitializeBoard()
    {
        

        // Store the original color of each square
        foreach (var square in squares)
        {
            Renderer renderer = square.GetComponent<Renderer>();
            if (renderer != null)
            {
                originalColors[square] = renderer.material.color;
            }
        }
    }



    private void UpdateSquareVisuals()
    {
        foreach (var square in squares)
        {
            Renderer renderer = square.GetComponent<Renderer>();
            if (renderer != null)
            {
                // Start with the original color
                Color color = originalColors.ContainsKey(square) ? originalColors[square] : Color.white;

                // Override the color based on conditions
                if (square.isKeyFragmentHere)
                {

                    // Instantiate the key fragment prefab above the square
                    if (keyFragmentPrefab != null)
                    {
                        Vector2 position = square.transform.position;
                        Instantiate(keyFragmentPrefab, position, Quaternion.identity);
                    }
                }
                if (square.isRookMove || square.isKnightMove || square.isBishopMove ||
                         square.isQueenMove || square.isKingMove)
                {
                    square.isPawnMove = false;
                    color = Color.blue; // Move possibilities are blue
                }
                if (square.isWallHere)
                {
                    // Instantiate the key fragment prefab above the square
                    if (wallPrefab != null)
                    {
                        Vector2 position = square.transform.position;
                        Instantiate(wallPrefab, position, Quaternion.identity);
                    }
                }
                if (square.isPlayerHere)
                {
                    // Instantiate the key fragment prefab above the square
                    if (playerPrefab != null)
                    {
                        Vector2 position = square.transform.position;
                        Instantiate(playerPrefab, position, Quaternion.identity);
                    }
                }


                // Update the square's color
                renderer.material.color = color;
            }
        }
    }

}
