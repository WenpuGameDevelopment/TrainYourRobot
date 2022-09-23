using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motion_Idle : StateMachineBehaviour
{
    InputReader inputReader = new KeyboardMouseInput();
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetInteger("Attack", 0);
        animator.SetInteger("HeavyAttack", 0);
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if(inputReader.GetAxis(out Vector2 xy))
        {
            animator.SetBool("Move", true);
        }
        if (inputReader.GetLightAttackButton())
        {
            animator.SetInteger("Attack", 1);
        }
        if (inputReader.GetHeavyAttackButton())
        {
            animator.SetInteger("HeavyAttack", 1);
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
}
