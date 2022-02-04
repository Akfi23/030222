using Kuhpik;
using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshBakerSystem : GameSystem,IIniting
{
    [SerializeField] [Tag] string levelTag;
    [SerializeField] private NavMeshSurface surface;
    void IIniting.OnInit()
    {
        surface = GameObject.FindGameObjectWithTag(levelTag).GetComponent<NavMeshSurface>();
        surface.BuildNavMesh();
    }
}
