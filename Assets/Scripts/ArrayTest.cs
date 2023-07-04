using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayTest : MonoBehaviour
{

    public GameObject[] objects;

    public Color[] colors;

    // Start is called before the first frame update
    void Start()
    {
        // Destroy( objects[2] ); // destroy element with index 2

        objects[0].GetComponent<Renderer>().material.color = colors[1]; // change color for 1nd elemnt of objects array
        objects[1].GetComponent<Renderer>().material.color = colors[0]; // change color for 2nd elemnt of objects array
        objects[2].GetComponent<Renderer>().material.color = colors[0]; // change color for 3rd elemnt of objects array
        objects[3].GetComponent<Renderer>().material.color = colors[2]; // change color for 4th elemnt of objects array
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
