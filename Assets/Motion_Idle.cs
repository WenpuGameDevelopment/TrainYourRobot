using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motion_Idle : StateMachineBehaviour
{
    InputReader inputReader = new KeyboardMouseInput();
    Transform main;
    Camera cam;
    public Rigidbody rb;
    public float turnSpeed = 5f;
    public float turnSpeedMultiplier = 25f;
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (rb == null) rb = animator.GetComponent<Rigidbody>();
        if (cam == null) cam = Camera.main;
        if (main == null) main = animator.transform;
        animator.SetBool("Attack", false);
        animator.SetInteger("HeavyAttack", 0);
        rb.velocity = Vector3.zero;
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetBool("Move", inputReader.HasMovementInput());
        if (inputReader.GetLightAttackButton())
        {
            animator.SetBool("Attack", true);
        }
        if (inputReader.GetHeavyAttackButton())
        {
            animator.SetInteger("HeavyAttack", 1);
        }
        if (inputReader.GetRollButton())
        {
            animator.SetTrigger("Roll");
        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
    public void RotateTowardTurnPoint(float turnSpeedMultiplier)
    {
        var currentInput = inputReader.GetAxis().To3DMovementAxis();
        var angle = Mathf.Atan2(currentInput.x, currentInput.z);
        angle = Mathf.Rad2Deg * angle;
        angle += cam.transform.eulerAngles.y;
        var targetRotation = Quaternion.Euler(0, angle, 0);
        main.rotation = Quaternion.Lerp(main.rotation, targetRotation, turnSpeedMultiplier * turnSpeed * Time.deltaTime);
    }
}
