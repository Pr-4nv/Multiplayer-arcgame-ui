using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class CreateAndJoinRooms : MonoBehaviourPunCallbacks

{
    
     public InputField createInput;
     public InputField joinInput;


     public void CreateRooms()

     {
        PhotonNetwork.CreateRoom(createInput.text);
     }


     public void joinRoom()

     {
        PhotonNetwork.JoinRoom(joinInput.text);
     }


    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();
        PhotonNetwork.LoadLevel("Game");
    }



}
