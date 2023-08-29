using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerInput : MonoBehaviour
{
    [SerializeField] private GameObject playerColliderVisual;
    [SerializeField] private GridController gridController;

    private Camera camera;
    private PlayerShapeSelect playerShapeSelect;
    private List<GridObject> setStateGrids;
    
    private void Start()
    {
        playerShapeSelect = GetComponent<PlayerShapeSelect>();
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
                    foreach (var shapeGrids in setStateGrids)
                    {
                        shapeGrids.visualData.IsEmpty = false;
                    }

                    InstatiateCurrentShapeObject(item.transform.position + new Vector3(0,1,0));

                }
            }
    }

    private bool CheckBuildingValid(GridVisualData data)
    {
        var currentShapeData = playerShapeSelect.CurrentShapeData;
        setStateGrids = new List<GridObject>();

        foreach (var item in currentShapeData)
        {
            var currentGrid = new Vector2Int(data.GridData.x,data.GridData.y);
            currentGrid += item;

            var accurateGrid = gridController.FindData(currentGrid);
            if(accurateGrid == null) return false;

            if(!accurateGrid.visualData.IsEmpty) return false;

            setStateGrids.Add(accurateGrid);
        }

        return true;
    }

    private void InstatiateCurrentShapeObject(Vector3 spawnPosition)
    {
        Instantiate(playerShapeSelect.CurrentShapeGO,spawnPosition,Quaternion.identity);
    }    

    
}
