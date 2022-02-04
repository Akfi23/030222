using Kuhpik;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdCameraChooserSystem : GameSystem, IIniting
{
    void IIniting.OnInit()
    {
        game.FirstPersonCamera.gameObject.SetActive(false);
        game.ThirdPersonCamera.gameObject.SetActive(true);
    }
}
