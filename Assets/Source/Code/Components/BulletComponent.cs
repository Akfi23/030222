using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletComponent : MonoBehaviour
{
    [SerializeField] private BulletConfig config;
    void Update()
    {
        transform.Translate(Vector3.forward * (config.BulletSpeed * Time.deltaTime));
    }
}
