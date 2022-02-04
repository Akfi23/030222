using UnityEngine;
using NaughtyAttributes;

namespace Kuhpik
{
    [CreateAssetMenu(menuName = "Kuhpik/GameConfig")]
    public sealed class GameConfig : ScriptableObject
    {
        [SerializeField] [Range(1f, 10f)] private float playerMovementSpeed;
        [SerializeField] [Range(1, 10)] private int attackSpeed;
        public float PlayerMovementSpeed => playerMovementSpeed;
        public int AttackSpeed => attackSpeed;
        
    }
}