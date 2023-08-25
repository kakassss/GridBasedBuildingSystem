using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputCollider : MonoBehaviour
{
    private const string GRID = "Grid";
    private Color InitColor;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag(GRID))
        {
            InitColor = other.GetComponent<MeshRenderer>().material.color;
            other.GetComponent<MeshRenderer>().material.color = Color.red;
        }    
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag(GRID))
        {
            other.GetComponent<MeshRenderer>().material.color = InitColor;    
        }      
    }
}
