using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolComponent : MonoBehaviour
{
    public Transform ShootPoint;

    [SerializeField] private ParticleSystem shootEffect;

    public void InitPistol()
    {
        ShootPoint = GetComponentInChildren<ShootPoint>().transform;
    }

    public void PlayeEffect()
    {
        shootEffect.Play();
    }
}
