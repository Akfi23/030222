using Kuhpik;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimSystem : GameSystem, IUpdating
{
    [SerializeField] private float mouseSensivity = 100f;
    [SerializeField] private float xRotation = 0f;

    void IUpdating.OnUpdate()
    {
        game.Player.Animator.Play("Aim");
        float mouseX = Input.GetAxis("Mouse X") * mouseSensivity * Time.deltaTime;
        float mouseY= Input.GetAxis("Mouse Y") * mouseSensivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90, 90);
        game.Player.transform.Rotate(Vector3.up * mouseX);       
    }
}
