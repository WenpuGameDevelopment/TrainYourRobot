using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motion_Roll : StateMachineBehaviour
{
    InputReader inputReader = new KeyboardMouseInput();
    Transform main;
    Camera cam;
    public Rigidbody rb;
    public float rollSpeed = 15f;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (rb == null) rb = animator.GetComponent<Rigidbody>();
        if (cam == null) cam = Camera.main;
        if (main == null) main = animator.transform;
        animator.ResetTrigger("Roll");
        animator.applyRootMotion = true;
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        rb.velocity = rb.velocity = main.forward * rollSpeed;
        animator.SetBool("Move", inputReader.HasMovementInput());
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        rb.velocity = Vector3.zero;
        animator.applyRootMotion = false;
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
}
