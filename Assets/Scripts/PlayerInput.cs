using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class PlayerInput : MonoBehaviour
{
    [SerializeField] private GameObject playerColliderVisual;

    [SerializeField] private GameObject tempGO;
    private Camera camera;

    private void Start()
    {
        camera = Camera.main;    
    }

    private void Update()
    {
        
        GridObject();
        
    }   

    private void GridObject()
    {
        var mousePosition = Input.mousePosition;
        mousePosition.z = camera.transform.position.y;

        var worldPosition = camera.ScreenToWorldPoint(mousePosition);
        playerColliderVisual.transform.position = worldPosition;

        if(Input.GetMouseButtonDown(0))
        {
            Collider[] colliders = Physics.OverlapSphere(worldPosition, 0.02f);

            foreach (var item in colliders)
            {
                if(!item.CompareTag("Grid")) return; 

                if(item.GetComponent<GridObject>().visualData.IsEmpty)
                {
                    var newgridd = item.GetComponent<GridObject>().visualData; 
                    newgridd.IsEmpty = false;
                    InstatiateObject(item.transform.position + new Vector3(0,1,0));

                }
            }
        }
    }

    private void InstatiateObject(Vector3 spawnPosition)
    {
        Instantiate(tempGO,spawnPosition,Quaternion.identity);
    }    

    
}
