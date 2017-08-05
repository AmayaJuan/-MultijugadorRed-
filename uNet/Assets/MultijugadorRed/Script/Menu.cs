using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Menu : MonoBehaviour
{
    MyNetworkDiscovery myNetworkDiscovery;

    void Awake()
    {
        myNetworkDiscovery = FindObjectOfType<MyNetworkDiscovery>();
    }

    void Start()
    {
        StopDiscovery();
    }

    public void CrearUnaPartida()
    {
        StopDiscovery();
        myNetworkDiscovery.StartAsServer();
        NetworkManager.singleton.StartHost();
    }

    public void UnirseAUnaPartida()
    {
        StopDiscovery();
        myNetworkDiscovery.StartAsClient();
    }

    void StopDiscovery()
    {
        if (myNetworkDiscovery.running)
            myNetworkDiscovery.StopBroadcast();
    }
}
