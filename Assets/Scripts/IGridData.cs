using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public interface IGridData
{
    public GameObject GridVisual {get; set;}
    public Transform GridTransform {get; set;}
    public Grid GridData {get; set;}
    public Color VisualColor {get; set;}
    public bool IsEmpty {get; set;}

    public void SetColor();
}
