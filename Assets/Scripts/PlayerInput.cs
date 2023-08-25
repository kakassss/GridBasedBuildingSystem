using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class PlayerInput : MonoBehaviour
{
    [SerializeField] private GameObject playerColliderVisual;
    private Camera camera;

    private void Start()
    {
        camera = Camera.main;    
    }

    private void Update()
    {
        var mousePosition = Input.mousePosition;
        mousePosition.z = camera.transform.position.y;

        var worldPosition = camera.ScreenToWorldPoint(mousePosition);
        playerColliderVisual.transform.position = worldPosition;

        Collider[] colliders = Physics.OverlapSphere(worldPosition, 0.02f);

        foreach (var item in colliders)
        {
            if(item.CompareTag("Grid"))
            {
                Debug.Log(item.name);
            }
        }
    }   

    
}
