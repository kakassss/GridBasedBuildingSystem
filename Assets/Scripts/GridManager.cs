using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField] private int xVector;
    [SerializeField] private int yVector;


    [HideInInspector] public Grid[,] grid;

    private void Awake()
    {
        grid = new Grid[xVector,yVector];
        GenerateGrid();

        //PrintGrid();    
    }

    private void GenerateGrid()
    {
        for (int i = 0; i < xVector; i++)
        {
            for (int y = 0; y < yVector; y++)
            {
                grid[i,y] = new Grid(i,y);
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
