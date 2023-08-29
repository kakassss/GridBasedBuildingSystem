using UnityEngine;

public struct GridData
{
    public int x;
    public int y;
    public GridData(int x,int y)
    {
        this.x = x;
        this.y = y;
    }


    public static bool operator ==(GridData op1,  GridData op2) 
    {
        return op1.Equals(op2);
    }

    public static bool operator !=(GridData op1,  GridData op2) 
    {
        return !op1.Equals(op2);
    }
}
