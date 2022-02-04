using Kuhpik;
using Supyrb;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OtherGameScreen : UIScreen
{
    [SerializeField] private Button restartButton;

    public override void Subscribe()
    {
        base.Subscribe();
        restartButton.onClick.AddListener(() => Restart());
    }
    private void Restart()
    {
        Signals.Clear();
        Bootstrap.SaveGame();
        Bootstrap.GameRestart(0);
    }
}
