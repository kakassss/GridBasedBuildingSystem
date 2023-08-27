using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField] private int xVector;
    [SerializeField] private int yVector;


    [HideInInspector] public Grid[,] grid;


    public static List<Vector2Int> listNeighborGrids = new List<Vector2Int>
    {
        new Vector2Int(1,1),
        new Vector2Int(1,-1),
        new Vector2Int(-1,1),

        new Vector2Int(1,0),
        new Vector2Int(0,1),

        new Vector2Int(-1,0),
        new Vector2Int(0,-1),
    };


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

    public static void CheckNeighborGrids(GridVisualData currentGrid)
    {
        var gridData = new Vector2(currentGrid.GridData.x,currentGrid.GridData.y);

        foreach (var item in listNeighborGrids)
        {
            
        }

    }




}
