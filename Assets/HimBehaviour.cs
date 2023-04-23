using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using Unity.Mathematics;
using UnityEngine;

public class HimBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("IK Objectives")]
    public Transform head;
    public Transform tail;
    public Transform rightArm;
    public Transform leftArm;
    public Transform rightArmAdjust;
    Vector3 lastRightArmPosition;
    public float armLimit;
    [SerializeField] Vector3 armsOffset;
    public float tailMovementSpeed;
    public float armsMovementSpeed;
    public float movementRange;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        var movement = Mathf.Clamp(Mathf.Sin(Time.time * tailMovementSpeed), -1, 1) / movementRange;

    }
}
