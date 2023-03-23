using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public string MyName;
    public string MyMenssage;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World, my name is "+ MyName +" - Start");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(MyMenssage + " - Update");
    }
}
