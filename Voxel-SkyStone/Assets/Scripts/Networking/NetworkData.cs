using System;
using System.Collections;
using SimpleJSON;
using UnityEngine;
using WebSocketSharp;

//[CreateAssetMenu(fileName = "NetworkData", menuName = "ScriptableObjects/NetworkData")]
namespace Networking
{
    public class NetworkData : ScriptableObject
    {
        [SerializeField] private bool localhost;

        private int _myId = 0;
        private int _playerTurnId = 0;


        public bool Localhost => localhost;

        public void SetPlayerTurn(int playerId)
        {
            _playerTurnId = playerId;
        }

        public void SetMyId(int id)
        {
            _myId = id;
        }

        public bool IsMyTurn()
        {
            return _myId == _playerTurnId;
        }
    }
}