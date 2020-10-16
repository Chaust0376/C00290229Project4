using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class MovingTarget : MonoBehaviour
{
    Vector3 target = new Vector3(0, 0, 0);
    public float moveSpeed = 6.0f;
    public Vector3 velocity = Vector3.zero;

   
    void Start()
    {
        target = transform.position;
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            UpdateTargetPosition();
        }

        SeekTarget();
    }

    void UpdateTargetPosition()
    {
        
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out RaycastHit hit, 100))
        {
            target = hit.point;
        }
    }

    void SeekTarget()
    {
       
        Vector3 dir = target - transform.position;
        
            Vector3 moveVector = dir.normalized * moveSpeed * Time.deltaTime;
            
            
    }
}
