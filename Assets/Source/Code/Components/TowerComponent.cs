using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TowerTypes
{
    FPSGame,
    OtherGame
}

public class TowerComponent : MonoBehaviour
{
    [SerializeField] private TowerTypes type;
    public TowerTypes Type => type;
}
