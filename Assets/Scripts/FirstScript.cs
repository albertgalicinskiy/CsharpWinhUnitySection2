using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    public int score = 10;
    float speed = 2.5f;
    char character = 'A'; // consists of one letter
    public string name = " Albert "; // so now we can use this variables outside of this script meanwhile value of this variable can be changed in the inspector


    // Start is called before the first frame update
    void Start()
    {
        // print (10);
        // print (score);
        print ("My name is: " + name);
        print ("My current score is: " + score);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
