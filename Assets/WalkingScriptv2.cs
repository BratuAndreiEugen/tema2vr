using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingScriptv2 : MonoBehaviour
{
    
    public Transform head;
    public Transform neck;
    public Transform torso;
    public Transform leftLeg;
    public Transform rightLeg;
    public Transform leftArm;
    public Transform rightArm;

    public float walkSpeed = 2f;
    public float strideLength = 0.1f;

    void RotateFromSwing(Transform member, float swingValue)
    {
        member.localRotation = Quaternion.Euler(swingValue, 0, 0);
    }

    void RotateLeftLeg()
    {
        float time = Time.time * walkSpeed;
        float legSwing = Mathf.Sin(time) * 20f;
        leftLeg.localRotation = Quaternion.Euler(-legSwing, 0, 0);
    }
    
    void RotateRightLeg()
    {
        float time = Time.time * walkSpeed;
        float legSwing = Mathf.Sin(time) * 20f;
        rightLeg.localRotation = Quaternion.Euler(legSwing, 0, 0);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float time = Time.time * walkSpeed;

        // Example walking animation - Adjust angles and keyframes as needed
        float headRotation = Mathf.Sin(time) * 10f;
        head.localRotation = Quaternion.Euler(headRotation, 0, 0);

        float torsoRotation = Mathf.Sin(time) * 5f;
        torso.localRotation = Quaternion.Euler(torsoRotation, 0, 0);

        float armSwing = Mathf.Sin(time) * 15f;
        leftArm.localRotation = Quaternion.Euler(armSwing, 0, 0);
        rightArm.localRotation = Quaternion.Euler(-armSwing, 0, 0);

        // float forearmSwing = Mathf.Sin(time) * 45f;
        // leftForearm.localRotation = Quaternion.Euler(forearmSwing, 0, 0);
        // rightForearm.localRotation = Quaternion.Euler(-forearmSwing, 0, 0);

        float legSwing = Mathf.Sin(time) * 20f;
        leftLeg.localRotation = Quaternion.Euler(-legSwing, 0, 0);
        rightLeg.localRotation = Quaternion.Euler(legSwing, 0, 0);
        

        // float lowerLegSwing = Mathf.Sin(time) * 30f;
        // leftLowerLeg.localRotation = Quaternion.Euler(lowerLegSwing, 0, 0);
        // rightLowerLeg.localRotation = Quaternion.Euler(-lowerLegSwing, 0, 0);
        //
        // float footSwing = Mathf.Sin(time) * 15f;
        // leftFoot.localRotation = Quaternion.Euler(footSwing, 0, 0);
        // rightFoot.localRotation = Quaternion.Euler(-footSwing, 0, 0);
        
        // Forward movement
        float forwardMovement = strideLength;
        transform.Translate(Vector3.forward * forwardMovement);
    }
}
