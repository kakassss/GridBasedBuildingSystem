using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridVisualizer : MonoBehaviour
{
    [SerializeField] GridManager gridManager;

    
    public GameObject gridVisual;

    private void Start()
    {
        CreateGridVisual();    
    }

    private void CreateGridVisual()
    {
        var firstDimensionLenght = gridManager.grid.GetLength(0);
        var secondDimensionLenght = gridManager.grid.GetLength(1);

        for (int i = 0; i < firstDimensionLenght; i++)
        {
            for (int y = 0; y < secondDimensionLenght; y++)
            {
                
                GridGO newGridVisual = new GridGO();
                newGridVisual.gridVisual = Instantiate(gridVisual);
                newGridVisual.gridData = gridManager.grid[i,y];

                newGridVisual.gridVisual.transform.position = new Vector3(newGridVisual.gridData.x,0,newGridVisual.gridData.y);
            }
        }
    }



}
public class GridGO 
{
    public GameObject gridVisual;
    public Grid gridData;
}
