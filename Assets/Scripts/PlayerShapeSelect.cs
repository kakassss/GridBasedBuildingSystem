using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerShapeSelect : MonoBehaviour
{
    public List<Vector2Int> CurrentShapeData = new List<Vector2Int>();
    public GameObject CurrentShapeGO;
    [SerializeField] private List<GameObject> shapes;
    private BuildingObjectDatas buildingObjectDatas;

    private void Awake()
    {
        buildingObjectDatas = new BuildingObjectDatas();    
    }
    
    private void Update()
    {
        ShapeSelectInput();
    }

    public void ShapeSelectInput()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            CurrentShapeData = buildingObjectDatas.ShapeOneUnit;
            CurrentShapeGO = shapes[0];
        }

        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            CurrentShapeData = buildingObjectDatas.ShapeL;
            CurrentShapeGO = shapes[1];
        }

        if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            CurrentShapeData = buildingObjectDatas.ShapeM;
            CurrentShapeGO = shapes[2];
        }

        if(Input.GetKeyDown(KeyCode.Alpha4))
        {
            CurrentShapeData = buildingObjectDatas.ShapePlus;
            CurrentShapeGO = shapes[3];
        }

        if(Input.GetKeyDown(KeyCode.Alpha5))
        {
            CurrentShapeData = buildingObjectDatas.ShapeT;
            CurrentShapeGO = shapes[4];
        }

        if(Input.GetKeyDown(KeyCode.Alpha6))
        {
            CurrentShapeData = buildingObjectDatas.ShapeI;
            CurrentShapeGO = shapes[5];
        }   
    }
}
