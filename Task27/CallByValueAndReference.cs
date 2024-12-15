using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Assignment27
{
    public class CallByValueAndReference : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            // Declare two integer variables
            int a = 5;
            int b = 10;

            // Call by Value Demonstration
            Debug.Log("Before CallByValue: " + a);
            CallByValue(a); // Passing 'a' by value
            Debug.Log("After CallByValue: " + a); // 'a' will not change outside the method

            // Call by Reference Demonstration
            Debug.Log("Before CallByReference: " + b);
            CallByReference(ref b); // Passing 'b' by reference
            Debug.Log("After CallByReference: " + b); // 'b' will change outside the method

            // Using the 'out' Keyword
            int c; // Declare but don't initialize
            CallByOut(out c); // Passing by out, initializes the variable inside the method
            Debug.Log("After CallByOut: " + c); // 'c' will be assigned inside the method
        }

        // Method to demonstrate Call by Value
        void CallByValue(int num)
        {
            num += 10; // Modify the value locally
            Debug.Log("Inside CallByValue: " + num); // This will show the modified value inside the method
        }

        // Method to demonstrate Call by Reference using 'ref'
        void CallByReference(ref int num)
        {
            num += 10; // Modify the value, which will reflect outside the method
            Debug.Log("Inside CallByReference: " + num); // This will show the modified value inside the method
        }

        // Method to demonstrate the 'out' keyword
        void CallByOut(out int num)
        {
            num = 20; // Assign a value to the out parameter inside the method
            Debug.Log("Inside CallByOut: " + num); // This will show the assigned value inside the method
        }
    }
}