using UnityEngine;
public class GridVisualData 
{
    public GameObject gridVisual;
    public Transform gridTransform;
    public Grid gridData;
    public Color visualColor;
    public bool IsEmpty;


    public void SetColor()
    {
        gridVisual.GetComponent<MeshRenderer>().material.color = visualColor;
    }
}
