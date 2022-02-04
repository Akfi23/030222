using Kuhpik;
using Kuhpik.Pooling;
using Supyrb;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingSystem : GameSystem, IUpdating
{
    [SerializeField] GameObject Bullet;
    [SerializeField] private float nextTimeToFire = 0f;

    void IUpdating.OnUpdate()
    {
        Shooting();
    }

    private void Shooting()
    {
        if (Input.GetMouseButton(0) && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1 / config.AttackSpeed;
            //var newBullet = Instantiate(Bullet, game.Player.Pistol.ShootPoint.transform.position, game.Player.transform.rotation);
            var newBullet = PoolingSystem.GetObject(Bullet);
            newBullet.transform.position = game.Player.Pistol.ShootPoint.transform.position;
            newBullet.transform.rotation = game.Player.transform.rotation;
            game.Player.Pistol.PlayeEffect();
        }
    }
}
