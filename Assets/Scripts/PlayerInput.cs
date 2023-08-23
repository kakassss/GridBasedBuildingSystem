using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerInput : MonoBehaviour
{
    private Color InitColor;
    private void OnMouseEnter() 
    {
        InitColor = GetComponent<MeshRenderer>().material.color;

        GetComponent<MeshRenderer>().material.color = Color.red;
    }

    private void OnMouseExit()
    {
        GetComponent<MeshRenderer>().material.color = InitColor;
    }

}
