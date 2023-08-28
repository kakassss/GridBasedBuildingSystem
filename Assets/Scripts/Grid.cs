using UnityEngine;

public struct Grid
{
    public int x;
    public int y;
    public Grid(int x,int y)
    {
        this.x = x;
        this.y = y;
    }


    public static bool operator ==(Grid op1,  Grid op2) 
    {
        return op1.Equals(op2);
    }

    public static bool operator !=(Grid op1,  Grid op2) 
    {
        return !op1.Equals(op2);
    }
}
