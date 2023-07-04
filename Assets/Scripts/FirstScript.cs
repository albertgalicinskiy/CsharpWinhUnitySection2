using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{

    bool playing = true;

    bool gameOver = true;
    
    public bool killPlayer; // in the Unity Inspector we will see checkbox

    // Start is called before the first frame update
    void Start()
    {
        
        if (playing) // or this one is the same ( playing == true )
        {
            print ("Playing");
        }
        else {
            print ("Game Over");
        }
        

        
        if ( !gameOver ) { // the same is ( gameOver == false ) // (gameOver) {
            print ("Game Over");
        }
        else {
            print ("Playing");
        }
        


    }

    // Update is called once per frame
    void Update()
    {
        if (killPlayer) {

            Destroy(gameObject, 2f); // Destroy game object that has this script is atached, 2f = 2 sec

        }
    }

}
