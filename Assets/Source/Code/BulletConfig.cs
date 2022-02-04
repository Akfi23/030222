using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Bullet/BulletConfig")]
public class BulletConfig : ScriptableObject
{
    [SerializeField] [Range(1, 10)] private int bulletSpeed;
    public int BulletSpeed => bulletSpeed;

}
