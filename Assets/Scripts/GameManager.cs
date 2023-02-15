using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public Transform[] Spawnpoints;
    void Start()
    {
        SpawnPlayer();
    }
    
    public void SpawnPlayer()
    {
        //PhotonNetwork.Instantiate(player.name, );
    }
}
