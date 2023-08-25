using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridVisualizer : MonoBehaviour
{
    [SerializeField] private GridManager gridManager;
    [SerializeField] private float horizontalDistance;
    [SerializeField] private float verticalDistance;

    public GameObject gridVisual;

    private List<GridVisualData> gridGOList;


    private int firstDimensionLenght;
    private int secondDimensionLenght;
    private float equalizer = 0.5f;

    private void Start()
    {
        gridGOList = new List<GridVisualData>();

        firstDimensionLenght = gridManager.grid.GetLength(0);
        secondDimensionLenght = gridManager.grid.GetLength(1);
        CreateGridVisual();    
    }

    private void CreateGridVisual()
    {
        for (int i = 0; i < firstDimensionLenght; i++)
        {
            for (int y = 0; y < secondDimensionLenght; y++)
            {

                GridVisualData newGridVisual = new()
                {
                    gridVisual = Instantiate(gridVisual),
                    gridTransform = gridVisual.transform,
                    gridData = gridManager.grid[i, y],
                    visualColor =  Color.blue,//Random.ColorHSV(),
                };

                newGridVisual.SetColor();

                bool isEven = firstDimensionLenght % 2 == 0;

                newGridVisual.gridTransform.position = 
                isEven 
                ? new Vector3(-firstDimensionLenght / 2 + i + equalizer ,0,-secondDimensionLenght/ 2 + y + equalizer)
                : new Vector3(-firstDimensionLenght / 2 + i ,0,-secondDimensionLenght/ 2 + y ) ;

                gridGOList.Add(newGridVisual);
            }
        }

        // for (int i = 0; i < firstDimensionLenght; i++)
        // {
        //     for (int y = 0; y < secondDimensionLenght; y++)
        //     {
        //         gridGOList[i].gridTransform 
                
        //     }
        // }

        

    }

    private void DivideIntoGroups()
    {
        
        if(firstDimensionLenght % 2 == 0) 

        //Left-Top Group
        for (int i = 0; i < firstDimensionLenght / 2; i++)
        {
            
        }



    }

}

