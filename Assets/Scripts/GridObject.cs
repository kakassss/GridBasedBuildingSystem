using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridObject : MonoBehaviour
{
    public GridVisualData visualData;

    public void CreateNewData(GridData data,Color color,bool state, Transform transform,GameObject go)
    {
        visualData = new()
        {
            GridData = data,
            VisualColor = color,
            IsEmpty = state,

            GridTransform = transform,
            GridVisual = go,
        };

        visualData.SetColor();
    }
}
