using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Prototype.NetworkLobby;
using UnityEngine.Networking;

public class NetworkLobbyHook : LobbyHook {

	public override void OnLobbyServerSceneLoadedForPlayer(NetworkManager manager, GameObject lobbyPlayer, GameObject gamePlayer)
	{
        LobbyPlayer lobby = lobbyPlayer.GetComponent<LobbyPlayer>();
        SetupLocalPlayer car = gamePlayer.GetComponent<SetupLocalPlayer>();

        car.pName = lobby.playerName;
        car.pColour = ColorUtility.ToHtmlStringRGBA(lobby.playerColor);
		//base.OnLobbyServerSceneLoadedForPlayer(manager, lobbyPlayer, gamePlayer);
	}
}
