using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerInput : MonoBehaviour
{
    [SerializeField] private GameObject playerColliderVisual;
    [SerializeField] private GameObject tempGO;

    [SerializeField] private GridVisualizer gridVisualizer;
    private Camera camera;

    private void Start()
    {
        camera = Camera.main;    
    }

    private void Update()
    {
        ApplyBuilding();
    }   

    private void ApplyBuilding()
    {
        CalculateVisualColliderPos();

        if(Input.GetMouseButtonDown(0))
        {
            ApplySelectedGrid();
        }
    }

    private void CalculateVisualColliderPos()
    {
        var mousePosition = Input.mousePosition;
        mousePosition.z = 8;

        var worldPosition = camera.ScreenToWorldPoint(mousePosition);
        playerColliderVisual.transform.position = worldPosition;
        playerColliderVisual.transform.position = new Vector3(playerColliderVisual.transform.position.x,0.3f,playerColliderVisual.transform.position.z);
    }

    private void ApplySelectedGrid()
    {
        Collider[] colliders = Physics.OverlapSphere(playerColliderVisual.transform.position, 0.01f);

            foreach (var item in colliders)
            {
                if(!item.CompareTag("Grid")) return; 

                if(!CheckBuildingValid(item.GetComponent<GridObject>().visualData)) return;

                if(item.GetComponent<GridObject>().visualData.IsEmpty)
                {
                    // var newgridd = item.GetComponent<GridObject>().visualData; 
                    // newgridd.IsEmpty = false;
                    foreach (var shapeGrids in setStateGrids)
                    {
                        shapeGrids.visualData.IsEmpty = false;
                    }

                    InstatiateObject(item.transform.position + new Vector3(0,1,0));

                }
            }
    }

    private List<GridObject> setStateGrids;

    private bool CheckBuildingValid(GridVisualData data)
    {
        var shapeT = BuildingObjectDatas.ShapeT;
        setStateGrids = new List<GridObject>();

        foreach (var item in shapeT)
        {
            var currentGrid = new Vector2Int(data.GridData.x,data.GridData.y);
            currentGrid += item;

            var accurateGrid = gridVisualizer.FindData(currentGrid);
            if(accurateGrid == null) return false;

            if(!accurateGrid.visualData.IsEmpty) return false;


            setStateGrids.Add(accurateGrid);
            //accurateGrid.visualData.IsEmpty = false;

        }

        return true;
    }

    private void InstatiateObject(Vector3 spawnPosition)
    {
        Instantiate(tempGO,spawnPosition,Quaternion.identity);
    }    

    
}
