using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World!!!");
    }

    // Update is called once per frame
    void Update()
    {
        while (counter <5)
        {
            Debug.Log(counter);
            counter++;
        }
        
    }
}