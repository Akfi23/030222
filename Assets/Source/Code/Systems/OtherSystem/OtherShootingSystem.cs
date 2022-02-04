using Kuhpik;
using Kuhpik.Pooling;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherShootingSystem : GameSystem, IUpdating
{
    [SerializeField] GameObject Bullet;
    [SerializeField] private float nextTimeToFire = 0f;
    private Vector3 direction;

    void IUpdating.OnUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, Mathf.Infinity))
            {
                Shooting(hit);
            }
        }
    }

    private void Shooting(RaycastHit hit)
    {
        if (Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1 / config.AttackSpeed;
            //var newBullet = Instantiate(Bullet, game.Player.Pistol.ShootPoint.transform.position, game.Player.RightArm.transform.rotation);
            var newBullet = PoolingSystem.GetObject(Bullet);
            newBullet.transform.position = game.Player.Pistol.ShootPoint.transform.position;
            newBullet.transform.LookAt(hit.point);
            game.Player.Pistol.PlayeEffect();
        }
    }
}
