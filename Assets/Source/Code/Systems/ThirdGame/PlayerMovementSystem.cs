using Kuhpik;
using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovementSystem : GameSystem, IIniting,IUpdating
{
    [SerializeField] [Range(0.05f, 0.2f)] float stoppingOffsetDistance;
    [SerializeField] EventSystem currentSystem;
    void IIniting.OnInit()
    {
        currentSystem = EventSystem.current;
    }

    void IUpdating.OnUpdate()
    {
        MovePlayer();
    }

    private  void MovePlayer()
    {
        if (Input.GetMouseButton(0))
        {
            game.Player.Agent.speed = config.PlayerMovementSpeed;
            RaycastHit hit;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, Mathf.Infinity))
            {
                if (currentSystem.IsPointerOverGameObject() == false)
                {                    
                    game.Player.Animator.Play("Run");
                    game.Player.Agent.SetDestination(hit.point);
                    Debug.Log(hit.collider.name);
                }
            }
        }

        if (game.Player.Agent.remainingDistance <= stoppingOffsetDistance)
        {
            game.Player.Animator.Play("Idle");
        }
    }
}
