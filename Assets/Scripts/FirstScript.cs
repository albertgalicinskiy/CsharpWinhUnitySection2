using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        // print ("Car Move!"); - called only once at the beginning

        
    }

    // Update is called once per frame
    void Update()
    {
        print ("Car Move!"); // keeps moving every time
        transform.Translate(speed, 0, 0);
    }

}
