using NaughtyAttributes;
using Supyrb;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(Rigidbody))]
public class EnemyComponent : CharacterComponent
{
    public Rigidbody Rigidbody;
    public List<Rigidbody> Bones;
    public Collider Collider;

    [Button]
    public override void InitCharacter()
    {
        Rigidbody = GetComponent<Rigidbody>();
        Agent = GetComponent<NavMeshAgent>();
        Animator = GetComponent<Animator>();
        Collider = GetComponent<Collider>();
        Collider.enabled = true;

        InteractWithBones(true);
    }

    public void InteractWithBones(bool status)
    {
        Animator.enabled = status;

        foreach (var bone in Bones)
        {
            bone.isKinematic = status;
            bone.useGravity = !status;
        }
    }

    public void Die()
    {
        Invoke("HideEnemy", 3f);
    }

    private void HideEnemy()
    {
        gameObject.SetActive(false);
        Signals.Get<OnEnemyShooted>().Dispatch();
    }
}
