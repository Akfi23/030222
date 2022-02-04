using Supyrb;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerListenerComponent : MonoBehaviour
{
    private BulletComponent bullet;
    private void OnEnable()
    {
        bullet = GetComponent<BulletComponent>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out EnemyComponent enemy))
        {
            Signals.Get<OnEnemyHitted>().Dispatch(enemy, bullet);
        }
    }
}
