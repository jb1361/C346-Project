using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;
public class NetworkController : NetworkBehaviour {
    public Vector3 spawnpos;
    public GameObject player;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
     
	}
    public void create(string ip, int port)
    {
       
        Network.InitializeServer(32, port,true);
        Debug.Log("Server Created");
       
       
    }
    public void OnServerInitialized()
    {
        SceneManager.LoadScene(1);
       
    }
    public void joinServer()
    {
        Debug.Log("Joining Server...");
        Network.Connect("127.0.0.1", 7777);
        SceneManager.LoadScene(1);
    }
    public void OnConnectedToServer()
    {
        
        Debug.Log("Conected");
        SpawnPlayer(player, spawnpos, 1);
    
    }
    public void SpawnPlayer(GameObject player,Vector3 SpawnPos, int num)
    {
     GameObject myPlayer = (GameObject)  Network.Instantiate(player, SpawnPos, Quaternion.identity, num);
        myPlayer.GetComponent<MovementController>().enabled = true;
        myPlayer.transform.Find("Camera").gameObject.SetActive(true);
        myPlayer.GetComponent<LockCursor>().enabled = true;
        myPlayer.GetComponent<MouseLook>().enabled = true;
      
       
    }

    public void OnGUI()
    {
        if(Network.peerType == NetworkPeerType.Server)
        {
            GUI.Label(new Rect(100,50,100,30),"Connections: " + Network.connections.Length);
          if(  GUI.Button(new Rect(0, 0, 75, 30), "Spawn"))
            {
                SpawnPlayer(player, spawnpos, 0);
            }
          
         

        }
       
    }
}
