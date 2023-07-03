using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{

    // int a = 5;
    public string name;

    // Start is called before the first frame update
    void Start()
    {
        /*
        if ( a == 5 ) {
            print ("A is 5");
        }
        */

        if ( name == "Albert" ) {
            print (" You are Albert ");
        }
        else {
            print (" You are not Albert, Your are " + name + "!");
        }


    }

    // Update is called once per frame
    void Update()
    {

    }

}
