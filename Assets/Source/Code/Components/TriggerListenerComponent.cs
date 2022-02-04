using Supyrb;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerListenerComponent : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out TowerComponent tower))
            Signals.Get<OnTowerCollideSignal>().Dispatch(true,tower.Type);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.TryGetComponent(out TowerComponent tower))
            Signals.Get<OnTowerCollideSignal>().Dispatch(false,tower.Type);
    }
}
