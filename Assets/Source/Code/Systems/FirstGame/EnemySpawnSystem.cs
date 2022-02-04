using Kuhpik;
using Kuhpik.Pooling;
using Supyrb;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnSystem : GameSystem, IIniting
{
    [SerializeField] private GameObject prefab;

    [SerializeField][Range(1,2)] private int spawnerNumber;

    void IIniting.OnInit()
    {
        Signals.Get<OnEnemyShooted>().AddListener(SpawnEnemy);
        SpawnEnemy();
    }

    private void SpawnEnemy()
    {
        if (spawnerNumber <= game.Level.EnemySpawner.Length)
        {
            int spawnRange = Random.Range(0, game.Level.EnemySpawner[spawnerNumber-1].SpawnPoints.Count);
            GameObject enemy = PoolingSystem.GetObject(prefab);
            enemy.GetComponent<EnemyComponent>().InitCharacter();
            enemy.transform.position = game.Level.EnemySpawner[spawnerNumber-1].SpawnPoints[spawnRange].position;
            enemy.transform.LookAt(game.Player.transform);
        }
    }
}
