using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEditor.U2D;
using UnityEngine;


public class NewBehaviourScript : MonoBehaviour
{
    string heroname = "joy boy";
    int heropowr = 200;
    float playerSpeed = 100;
    //
    string villainame = "zero";
    int villaipowr = 50;
    // Start is called before the first frame update
    void Start()
    {
        if (heropowr >= villaipowr)

            print("heropowr is stronger than villaipowr");
        
       
        else if (heropowr < villaipowr) ;

        print("The villain is stronger than the hero");


        setspeed(2.5f);

        print(playerSpeed);
    }


    void setspeed(float speed)
    {
        playerSpeed = speed;
        
    }









    // Update is called once per frame
    void Update()
    {
      






    }

}