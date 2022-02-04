using Kuhpik;
using NaughtyAttributes;
using Supyrb;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLoadingSystem : GameSystem, IIniting
{
    [SerializeField] [Tag] string playerTag;
    void IIniting.OnInit()
    {
        Bootstrap.SaveGame();
        game.Player = GameObject.FindGameObjectWithTag(playerTag).GetComponent<PlayerComponent>();
        game.Player.InitCharacter();
    }
}
