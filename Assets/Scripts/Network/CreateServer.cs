using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CreateServer : MonoBehaviour {
    NetworkController network;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void createServer()
    {
        network = GameObject.FindGameObjectWithTag("NetworkController").GetComponent<NetworkController>();
        network.create("127.0.0.1",7777);
        Debug.Log("Creating Server");
        
       
    }
}
