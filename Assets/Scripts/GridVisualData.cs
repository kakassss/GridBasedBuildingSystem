using UnityEngine;
public class GridVisualData
{
    public GameObject GridVisual;
    public Transform GridTransform;
    public Grid GridData;
    public Color VisualColor;
    public bool IsEmpty;


    public void SetColor()
    {
        GridVisual.GetComponent<MeshRenderer>().material.color = VisualColor;
    }
}
