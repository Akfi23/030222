using Kuhpik;
using Supyrb;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstPersonGameScreen : UIScreen
{
     [SerializeField] private Button backButton;

    public override void Subscribe()
    {
        base.Subscribe();

        backButton.onClick.AddListener(() =>Restart());
    }

    private void Restart()
    {
        Signals.Clear();
        Bootstrap.SaveGame();
        Bootstrap.GameRestart(0);
    }
}
