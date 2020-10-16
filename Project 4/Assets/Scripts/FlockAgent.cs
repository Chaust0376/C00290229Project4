using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

[RequireComponent(typeof(Collider3D))]
public class FlockAgent : MonoBehaviour
{
    Collider3D agentCollider;
    public Collider3D AgentCollider { get { return agentCollider; } }

    // Start is called before the first frame update
    void Start()
    {
        agentCollider = GetComponent<Collider3D>();
    }

    public void Move(Vector3 velocity)
    {
        transform.forward = velocity;
        transform.position += velocity * Time.deltaTime;
    }
}
