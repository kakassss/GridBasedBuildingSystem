using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridVisualizer : MonoBehaviour
{
    [SerializeField] private GridManager gridManager;
    [SerializeField] private float horizontalDistance;
    [SerializeField] private float verticalDistance;

    public GridObject GridObject;

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

                var newGrid = Instantiate(GridObject);
                var newGridData = newGrid.visualData;

                newGrid.CreateNewData(gridManager.grid[i, y],Color.blue,true,newGrid.transform,newGrid.gameObject);

                bool isEven = firstDimensionLenght % 2 == 0;

                newGrid.transform.position = 
                isEven 
                ? new Vector3(-firstDimensionLenght / 2 + i + equalizer ,0,-secondDimensionLenght/ 2 + y + equalizer)
                : new Vector3(-firstDimensionLenght / 2 + i ,0,-secondDimensionLenght/ 2 + y ) ;

                gridGOList.Add(newGridData);
            }
        }
    }



}

