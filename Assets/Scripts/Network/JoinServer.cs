using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoinServer : MonoBehaviour {
    NetworkController network;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void joinServer()
    {
        network = GameObject.FindGameObjectWithTag("NetworkController").GetComponent<NetworkController>();
        network.joinServer();
    }
    
}
