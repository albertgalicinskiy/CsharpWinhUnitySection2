using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        TestFunction();
    }

    // Update is called once per frame
    void Update()
    {

    }

    // single comment
    /* multiline comment */ 

    void TestFunction() // we don't want function to return anything
    {
        print ("Shoot");
        print ("Destroy");
        print ("Move");
        transform.Translate(speed, 0, 0);
    }

}
