
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Flock : MonoBehaviour
{
    public float speed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(0.5f, 1);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, Time.deltaTime * speed);
    }
}
