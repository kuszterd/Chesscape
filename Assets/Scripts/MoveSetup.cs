using UnityEngine;
using UnityEngine.UIElements;

public class MoveSetup : MonoBehaviour
{
    // Moves
    public bool Pawn;
    public bool Rook;
    public bool Knight;
    public bool Bishop;
    public bool Queen;
    public bool King;

    // Direction
    public bool Up;
    public bool Down;
    public bool Left;
    public bool Right;
    public bool UpLeft;
    public bool UpRight;
    public bool DownLeft;
    public bool DownRight;
    public bool LeftUp;
    public bool LeftDown;
    public bool RightUp;
    public bool RightDown;

    // Distance
    public int distance;

    public void CopyFrom(MoveSetup other)
    {
        //copy moves
        Pawn = other.Pawn;
        Rook = other.Rook;
        Knight = other.Knight;
        Bishop = other.Bishop;
        Queen = other.Queen;
        King = other.King;
        //copy directions
        Up = other.Up;
        Down = other.Down;
        Left = other.Left;
        Right = other.Right;
        UpLeft = other.UpLeft;
        UpRight = other.UpRight;
        DownLeft = other.DownLeft;
        DownRight = other.DownRight;
        LeftUp = other.LeftUp;
        LeftDown = other.LeftDown;
        RightUp = other.RightUp;
        RightDown = other.RightDown;
        //copy distance
        distance = other.distance;
    }
}
