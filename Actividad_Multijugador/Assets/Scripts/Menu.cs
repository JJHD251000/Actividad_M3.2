using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Menu : MonoBehaviour
{
    MyNetworkDiscovery myNetworkDiscovery;

    void Awake() {
        myNetworkDiscovery = FindObjectOfType<MyNetworkDiscovery>();
    }

    void Start() {
        StopDiscovery();
    }
    
    public void CreateParty() {
        StopDiscovery();
        myNetworkDiscovery.StartAsServer();
        NetworkManager.singleton.StartHost();
    }

    public void JoinParty() {
        StopDiscovery();
        myNetworkDiscovery.StartAsClient();
    }

    private void StopDiscovery() {
        if(myNetworkDiscovery.running) {
            myNetworkDiscovery.StopBroadcast();
        }
    }
}
