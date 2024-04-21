using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public string myMessage;
    public Vector3 positionChange;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("HelloWorld() :: Start() :: Initializing start function");  
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("HelloWorld() :: Update() :: Running Update function"+myMessage);
    }
}
