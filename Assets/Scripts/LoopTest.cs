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

    /*  Basic structure of While Loop

    initialize/counter outside
    while ( Condition ) {
        // Do things

        Increment value
    }
    */

    // Start is called before the first frame update
    void Start()
    {
//        print ("Before Entering For Loop");
//        for ( int i = 1 ; i < 11 ; i++ ) {
//            print ("Albert");
//        }        
//        print ("After Exiting For Loop");

        print ("Before Entering While Loop");

        int i = 1;

        while ( i <= 10 ) {
            // print ("Albert");
            print(i);

            i++;
        }

        print ("After Exiting While Loop");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
