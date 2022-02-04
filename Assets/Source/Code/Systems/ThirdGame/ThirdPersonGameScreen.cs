using Kuhpik;
using Supyrb;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThirdPersonGameScreen : UIScreen
{
    public Button FPSButton;
    public Button OtherButton;
    public Dictionary<TowerTypes, Button> Buttons=new Dictionary<TowerTypes, Button>();
    public override void Subscribe()
    {
        Buttons.Add(TowerTypes.FPSGame, FPSButton);
        Buttons.Add(TowerTypes.OtherGame, OtherButton);

        FPSButton.onClick.AddListener(() => Bootstrap.ChangeGameState(EGamestate.FirstGame));
        OtherButton.onClick.AddListener(() => Bootstrap.ChangeGameState(EGamestate.OtherGame));
        Signals.Get<OnTowerCollideSignal>().AddListener(ToggleButton);
    }

    private void ToggleButton(bool status,TowerTypes type)
    {
        Buttons[type].gameObject.SetActive(status);
    }
}
