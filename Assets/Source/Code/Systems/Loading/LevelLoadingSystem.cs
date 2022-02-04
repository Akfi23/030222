using Kuhpik;
using Kuhpik.Pooling;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoadingSystem : GameSystem, IIniting
{
    void IIniting.OnInit()
    {
        game.Level = FindObjectOfType<LevelComponent>();
        game.Level.InitLevel();

    }
}
