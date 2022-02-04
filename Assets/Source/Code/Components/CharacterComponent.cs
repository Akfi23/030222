using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public abstract class CharacterComponent : MonoBehaviour
{
    public NavMeshAgent Agent;
    public Animator Animator;

    public abstract void InitCharacter();
}
