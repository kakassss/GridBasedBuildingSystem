using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingObjectDatas 
{
    public List<Vector2Int> ShapeOneUnit = new()
    {
        new Vector2Int(0,0),
    };
    
    public List<Vector2Int> ShapeT = new()
    {
        new Vector2Int(0,0),
        new Vector2Int(1,0),
        new Vector2Int(-1,0),
        new Vector2Int(0,1),
    };

    public List<Vector2Int> ShapeL = new()
    {
        new Vector2Int(0,0),
        new Vector2Int(1,0),
        new Vector2Int(-1,0),
        new Vector2Int(1,1),
    };
    public List<Vector2Int> ShapeI = new()
    {
        new Vector2Int(0,0),
        new Vector2Int(1,0),
        new Vector2Int(-1,0),
    };
    public List<Vector2Int> ShapePlus = new()
    {
        new Vector2Int(0,0),
        new Vector2Int(1,0),
        new Vector2Int(-1,0),
        new Vector2Int(0,1),
        new Vector2Int(0,-1),
    };
    public List<Vector2Int> ShapeM = new()
    {
        new Vector2Int(0,0),
        new Vector2Int(1,0),
        new Vector2Int(-1,0),
        new Vector2Int(1,1),
        new Vector2Int(-1,1),
    };

}
