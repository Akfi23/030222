using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelComponent : MonoBehaviour
{
    public EnemySpawnerComponent[] EnemySpawner;

    public void InitLevel()
    {
        EnemySpawner = GetComponentsInChildren<EnemySpawnerComponent>();
    }
}
