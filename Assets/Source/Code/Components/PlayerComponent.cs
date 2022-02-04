using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerComponent : CharacterComponent
{
    public PistolComponent Pistol;
    public GameObject RightArm;
    public override void InitCharacter()
    {
        Agent = GetComponent<NavMeshAgent>();
        Animator = GetComponentInChildren<Animator>();
        Pistol = GetComponentInChildren<PistolComponent>();
        RightArm = GetComponentInChildren<RightArmComponent>().gameObject;
        Pistol.InitPistol();
    }
}
