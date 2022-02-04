using Kuhpik;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherAimSystem : GameSystem, IUpdating,IIniting
{
    [SerializeField] private GameObject Arm;
    void IIniting.OnInit()
    {
        game.Player.Animator.Play("Aim");
        Arm = game.Player.RightArm;
    }

    void IUpdating.OnUpdate()
    {
        Ray cameraRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        float rayDistance;
        Plane plane = new Plane(Vector3.up, Vector3.zero);

        if(plane.Raycast(cameraRay,out rayDistance))
        {
            Vector3 lookAtPoint = cameraRay.GetPoint(rayDistance);
            Arm.transform.LookAt(new Vector3(lookAtPoint.x,Arm.transform.position.z, lookAtPoint.z));
        }
    }
}
