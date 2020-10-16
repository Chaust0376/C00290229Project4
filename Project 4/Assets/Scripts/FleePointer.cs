using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FleePointer : MonoBehaviour
{
    public Transform target;
    public float moveSpeed = 6.0f;
    private float maxDistance = 5.0f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Call to the fucntion every frame
        FleeTarget();
    }

    void FleeTarget()
    {
        //Subtracting two vectors by each will result in the desired direction
        Vector3 dir = target.position - transform.position;
        //Simple check to see if we continue seeking the target or if we are already at our desired distance from target
        if (dir.magnitude < maxDistance)
        {
            Vector3 moveVector = dir.normalized * moveSpeed * Time.deltaTime;
            //If the case check true, we continue moving towards our target
            transform.position -= moveVector;
        }
    }
}