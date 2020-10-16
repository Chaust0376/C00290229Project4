using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MoveTarget : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            UpdateTargetPosition();
        }
    }
    void UpdateTargetPosition()
    {
        // Don’t forget to add a plane on the ground in the Unity Scene
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out RaycastHit hit, 100))
        {
            transform.position = hit.point;
        }
    }
}