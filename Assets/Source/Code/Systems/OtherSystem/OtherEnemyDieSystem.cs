using Kuhpik;
using Supyrb;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherEnemyDieSystem : GameSystem, IIniting
{
    void IIniting.OnInit()
    {
        Signals.Get<OnEnemyHitted>().AddListener(KillEnemy);
    }

    private void KillEnemy(EnemyComponent enemy, BulletComponent bullet)
    {
        bullet.gameObject.SetActive(false);
        enemy.InteractWithBones(false);
        enemy.Rigidbody.AddForceAtPosition(Vector3.zero, enemy.transform.position,ForceMode.Force);

        StartCoroutine(OnEnemyKilled(enemy));
    }

    IEnumerator OnEnemyKilled(EnemyComponent enemy)
    {
        yield return new WaitForSeconds(3f);
        enemy.gameObject.SetActive(false);
        Signals.Get<OnEnemyShooted>().Dispatch();
    }
}
