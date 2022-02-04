using Cinemachine;
using Kuhpik;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLoadingSystem : GameSystem,IIniting
{
    [SerializeField] private CinemachineVirtualCamera ThirdPersonCamera;
    [SerializeField] private CinemachineVirtualCamera FirstPersonCamera;

    void IIniting.OnInit()
    {
        InitCameras();
    }

    private void InitCameras()
    {
        game.ThirdPersonCamera = this.ThirdPersonCamera;
        game.FirstPersonCamera = this.FirstPersonCamera;

        game.ThirdPersonCamera.Follow = game.Player.transform;
        game.ThirdPersonCamera.LookAt = game.Player.transform;

        game.FirstPersonCamera.Follow = game.Player.transform;
        game.FirstPersonCamera.LookAt = game.Player.transform;

        game.FirstPersonCamera.gameObject.SetActive(true);
        game.ThirdPersonCamera.gameObject.SetActive(false);
    }
}
