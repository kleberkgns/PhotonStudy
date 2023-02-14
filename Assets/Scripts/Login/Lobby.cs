using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;
using TMPro;
using UnityEngine.SceneManagement;
public class Lobby : MonoBehaviourPunCallbacks
{
    public TMP_InputField createRoom;
    public TMP_InputField joinRoom;
    
    public void CreateRoomButton()
    {
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = 4;
        PhotonNetwork.CreateRoom(createRoom.text, roomOptions, null);
    }

    public void JoinRoomButton()
    {
        PhotonNetwork.JoinRoom(joinRoom.text, null);
    }

    public override void OnJoinedRoom()
    {
        SceneManager.LoadScene(1);
    }

    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        Debug.Log("Room failed:" + returnCode + "Message:" + message);
    }
}
