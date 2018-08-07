using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class NetWorkCtrl : MonoBehaviour {
    NetworkManager networkManager;
    NetworkClient netClient;
	// Use this for initialization
	void Start () {
        networkManager = GetComponent<NetworkManager>();
    }

    public void StartHost()
    {
        Debug.Log("StartingHost");
        networkManager.StartHost();
        Debug.Log("StartHost");
    }

    public void StartClient()
    {
        netClient = networkManager.StartClient();
    }

    public void StopClient()
    {
        networkManager.StopClient();
    }

    public void StopHost()
    {
        networkManager.StopHost();
    }
}
