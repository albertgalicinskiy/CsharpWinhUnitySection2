using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayTest : MonoBehaviour
{

    public int[] rollNumber;

    string[] names = new string[4];

    // Start is called before the first frame update
    void Start()
    {

        names[0] = "Albert";
        names[1] = "Alba";
        names[2] = "Alberto";
        names[3] = "Albertinho";

        print ( names[3] );
        print ( names[0] );


        print (rollNumber[2]);
        print ( rollNumber.Length );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
