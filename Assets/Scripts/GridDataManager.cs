using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridDataManager : MonoBehaviour
{
    [SerializeField] private int xVector;
    [SerializeField] private int yVector;

    [HideInInspector] public GridData[,] grid;

    private void Awake()
    {
        grid = new GridData[xVector,yVector];
        GenerateGrid();
        //PrintGrid();    
    }

    private void GenerateGrid()
    {
        for (int i = 0; i < xVector; i++)
        {
            for (int y = 0; y < yVector; y++)
            {
                grid[i,y] = new GridData(i,y);
            }
        }

    }

    private void PrintGrid()
    {
        for (int i = 0; i < xVector; i++)
        {
            for (int y = 0; y < yVector; y++)
            {
                Debug.Log(new Vector2(grid[i,y].x,grid[i,y].y));
            }
        }

    }


}
