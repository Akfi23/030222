using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerComponent : MonoBehaviour
{
    [SerializeField] private List<Transform> spawnPoints;
    public List<Transform> SpawnPoints => spawnPoints;
}
