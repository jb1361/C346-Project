using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class LockCursor : NetworkBehaviour {
    bool locked;
	// Use this for initialization
	void Start () {
      
        locked = true;
        Application.runInBackground = true;
    }
	
	// Update is called once per frame
	void Update () {
        
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                locked = !locked;
            }

            if (locked)
            {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;

            }
            else
            {
            
                
            Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;

            
        }
	}
}
