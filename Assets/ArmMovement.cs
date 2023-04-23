using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmMovement : MonoBehaviour
{
    HimBehaviour behaviour;
    public Transform adjust;
    float armsMovementSpeed;
    Vector3 lastPosition;
    float armLimit;
    void Start()
    {
        behaviour = GetComponentInParent<HimBehaviour>();
        armsMovementSpeed = behaviour.armsMovementSpeed;
        armLimit = behaviour.armLimit;

    }

    void Update()
    {

        var ray = new Ray(adjust.position, Vector3.down);
        if (Physics.Raycast(ray, out RaycastHit hit, 8f))
        {
            if (Vector3.Distance(hit.point, transform.position) > armLimit)
            {
                lastPosition = hit.point;
            }
            transform.position = Vector3.Lerp(transform.position, lastPosition, armsMovementSpeed);
        }

    }
}
