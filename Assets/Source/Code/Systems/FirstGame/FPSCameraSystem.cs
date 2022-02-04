using Kuhpik;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSCameraSystem : GameSystem, IIniting
{
    void IIniting.OnInit()
    {
        game.FirstPersonCamera.gameObject.SetActive(true);
        game.ThirdPersonCamera.gameObject.SetActive(false);
    }
}
