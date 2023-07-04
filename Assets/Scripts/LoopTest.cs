using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopTest : MonoBehaviour
{
    /*  Basic structure of For Loop
    for ( initialization/counter ; Condition ; increment ) {
        // Do things
    }
    */

    // Start is called before the first frame update
    void Start()
    {
        print ("Before Entering For Loop");

        for ( int i = 1 ; i < 11 ; i++ ) {
            print ("Albert");
        }        

        print ("After Exiting For Loop");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
