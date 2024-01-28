using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public Rigidbody2D myRigidBody2d;


        int numberOfTimes = 5;
        string nameOfThekey = "ENTER";
        float speedOfBreaking = 6.94f;

        void Start()
    {
        //PrintingToOurConsole();
    }
    


    // Update is called once per frame
    void Update()
        {
            MovingOurCube();

            OutOfBoundsPrinter();
        }


         public string PrintingFromOutside(int value)
         {
            
            string printSomething = "The value we were sent is " + value;
        
            return printSomething;
         }

        

        private void OutOfBoundsPrinter()
        {
            if (transform.position.x > 9.5f)
            {
                Debug.LogWarning("Our cube is out of bounds to the Right side!");
            }

            else if (transform.position.x < -9.5f)
            {
                Debug.LogWarning("Our cube is out of bounds to the Left side!");
            }

            else if (transform.position.y < 5.5f)
            {
                Debug.LogWarning("Our cube is out of bounds to the Top side!");
            }

        }

        private void MovingOurCube()
        {
            if (Input.GetKeyUp(KeyCode.UpArrow))
            {
                myRigidBody2d.velocity = new Vector2(0f, 10f);
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                myRigidBody2d.velocity = new Vector2(0f, -10f);
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                myRigidBody2d.velocity = new Vector2(-10f, 0f);
            }

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                myRigidBody2d.velocity = new Vector2(10f, 0f);
            }
        }

        private void PrintingToOurConsole()
        {
            Debug.Log("If you press the up arrow you'll JUMP!!.");
            Debug.Log("If you press the right arrow " + numberOfTimes + " you'll move!");

            Debug.LogWarning("Warning: If you press the " + nameOfThekey + ", nothing happens");
            Debug.LogError("If you smash the keyboard at a speed of " + speedOfBreaking + " nothing happens, you just cry...");
        }
  

}
