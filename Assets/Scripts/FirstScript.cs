using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    public int score;

    // Start is called before the first frame update
    void Start()
    {

        if ( score <= 0 ) {
            print ("Game Over!");
        }
        else if ( score > 0 && score < 10 ) {
            print ("Level 1");
        }
        else if ( score > 10 ) {
            print ("Level 2");
        }
        else {
            print ("Game is Running!");
        }

    }

    // Update is called once per frame
    void Update()
    {

    }

}
