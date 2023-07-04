using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchTest : MonoBehaviour
{

    public int power = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (power)
        {
            case 1: // means if power is 1
                print("You Are Beginner Player");
                break;
            case 2:
                print("You Are Intermediate Player");
                break;
            case 3:
                print("You Are an Advanced Player");
                break;
            default:
                print("You are not a Player");
                break;
        }
    }
}
