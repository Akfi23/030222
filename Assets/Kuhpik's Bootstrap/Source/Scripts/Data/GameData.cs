using UnityEngine;
using Cinemachine;

namespace Kuhpik
{
    /// <summary>
    /// Used to store game data. Change it the way you want.
    /// </summary>
    public class GameData
    {
        // Example (I use public fields for data, but u free to use properties\methods etc)
        // public float LevelProgress;
        // public Enemy[] Enemies;

        public PlayerComponent Player;
        public LevelComponent Level;

        public CinemachineVirtualCamera ThirdPersonCamera;
        public CinemachineVirtualCamera FirstPersonCamera;
    }
}