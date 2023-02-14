using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class NetworkController : MonoBehaviourPunCallbacks
{
    public GameObject ConnectedScreen;
    public GameObject DisconnectedScreen;
    
    public void ConnectButton()
    {
        PhotonNetwork.ConnectUsingSettings();
    }
    
    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby(TypedLobby.Default);
    }

    public override void OnDisconnected(DisconnectCause cause)
    {
        DisconnectedScreen.SetActive(true);
    }

    public override void OnJoinedLobby()
    {
        ConnectedScreen.SetActive(true);
    }
}
