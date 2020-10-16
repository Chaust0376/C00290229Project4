

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalFlock : MonoBehaviour
{
    public GameObject leafPrebab;
    public static int tankSize = 5;

    static int numLeaves = 100;
    public static GameObject[] allLeaves = new GameObject[numLeaves];

    public static Vector3 goalPos = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        for (int i=0; i<numLeaves; i++)
        {
            Vector3 pos = new Vector3(Random.Range(-tankSize, tankSize), Random.Range(-tankSize, tankSize), Random.Range(-tankSize, tankSize));
            allLeaves[i] = (GameObject) Instantiate(leafPrebab, pos, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Random.Range(0, 1000) < 50)
        {
            goalPos = new Vector3(Random.Range(-tankSize, tankSize), Random.Range(-tankSize, tankSize), Random.Range(-tankSize, tankSize));
        }
    }
}
