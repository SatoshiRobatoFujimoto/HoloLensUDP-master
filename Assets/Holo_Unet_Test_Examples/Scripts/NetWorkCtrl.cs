using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class NetWorkCtrl : MonoBehaviour {
    NetworkManager networkManager;
    NetworkClient netClient;
	// Use this for initialization
	void Start () {
		//寻找组件Net
        networkManager = GetComponent<NetworkManager>();
    }

    /// <summary>
    /// 打开本地服务器
    /// </summary>
    public void StartHost()
    {
        Debug.Log("StartingHost");
        networkManager.StartHost();
        Debug.Log("StartHost");
    }
    /// <summary>
    /// 创建链接
    /// </summary>
    public void StartClient()
    {
        netClient = networkManager.StartClient();
    }
    /// <summary>
    /// 关闭链接
    /// </summary>
    public void StopClient()
    {
        networkManager.StopClient();
    }
    /// <summary>
    /// 关闭本地数据库
    /// </summary>
    public void StopHost()
    {
        networkManager.StopHost();
    }
}
