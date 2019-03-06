//smeerws: 
//printing messages to the unity console

using System;
using UnityEngine;


public class HelloWorld : MonoBehaviour 
{

	void Start () 
    {
        string message = "Hello World";

        print(message);
        Debug.Log(message);
        Console.WriteLine(message);

        print("print" + message);
        Debug.Log("Debug.Log" + message);
        Console.WriteLine("Console.WriteLine" + message);
    }
	
}
