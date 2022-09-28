using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motion_Move : StateMachineBehaviour
{
    InputReader inputReader = new KeyboardMouseInput();
    public float movementSpeed = 5f;
    public float turnSpeed = 5f;
    public float turnSpeedMultiplier;
    Transform main;
    Camera cam;
    public Rigidbody rb;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (rb == null) rb = animator.GetComponent<Rigidbody>();
        if (cam == null) cam = Camera.main;
        if (main == null) main = animator.transform;
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //Vector3 direction = cam.transform.TransformDirection(inputReader.GetAxis().To3DMovementAxis());
        //direction.y = 0;
        //rb.velocity = direction * movementSpeed;
        animator.SetBool("Move", inputReader.HasMovementInput());
        if (inputReader.HasMovementInput())
        {
            rb.velocity = main.forward * movementSpeed;
            //main.position += main.forward * movementSpeed * Time.deltaTime;
            Rotate();
        }
        if (inputReader.GetLightAttackButton())
        {
            animator.SetInteger("Attack", 1);
        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

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

    public void Rotate()
    {
        var currentInput = inputReader.GetAxis().To3DMovementAxis();
        var angle = Mathf.Atan2(currentInput.x, currentInput.z);
        angle = Mathf.Rad2Deg * angle;
        angle += cam.transform.eulerAngles.y;
        var targetRotation = Quaternion.Euler(0, angle, 0);
        //main.rotation = Quaternion.Slerp(main.rotation, targetRotation, turnSpeed * Time.deltaTime);
        rb.rotation = Quaternion.Lerp(main.rotation, targetRotation, turnSpeedMultiplier * turnSpeed * Time.deltaTime);
    }

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
