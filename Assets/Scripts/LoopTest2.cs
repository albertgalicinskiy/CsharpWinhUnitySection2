using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopTest2 : MonoBehaviour
{

    public GameObject[] objects;

    // Start is called before the first frame update
    void Start()
    {
        
        foreach (GameObject o in objects)
        {
            // Destroy(o); // Delete objects one by one from objects array
            o.SetActive(true); // Enable objects one by one from objects array
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
