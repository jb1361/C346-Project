using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.Networking;
public class MovementController : NetworkBehaviour
{
    public float speed;
    float horizontal;
    float vertical;
    Rigidbody playerRB;
    // Use this for initialization
    void Start () {
        if (!this.GetComponent<NetworkView>().isMine)
            this.enabled = false;
        playerRB = this.GetComponent<Rigidbody>();
	}
    void Update()
    {
       // Debug.Log("Horiz: " + horizontal + " Vert: " + vertical);
    }
    // Update is called once per frame
    void FixedUpdate()
    {
       
            horizontal = CrossPlatformInputManager.GetAxis("Horizontal");
            vertical = CrossPlatformInputManager.GetAxis("Vertical");
            Vector3 movDir = this.transform.forward * vertical * speed + this.transform.right * horizontal * speed;
            playerRB.velocity = movDir;
        
    }
}
