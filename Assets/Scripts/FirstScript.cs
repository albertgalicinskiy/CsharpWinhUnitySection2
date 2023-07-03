using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{

    // public int number;

    public string MyName;

    // Start is called before the first frame update
    void Start()
    {
       // int returnedNumber = GiveDouble(5);
       // print (returnedNumber);

       // PrintName("Albert");
       PrintName(MyName);

    }

    // Update is called once per frame
    void Update()
    {

    }

    /*
    int GiveDouble() // function will always return int
    {
        return (number * 2);
    }
    */

    int GiveDouble(int val)
    {
        return (val * 2);
    }

    void PrintName( string name )
    {
        print ("My name is " + name);
    }



    void TestFunction() // we don't want function to return anything
    {

    }

}
