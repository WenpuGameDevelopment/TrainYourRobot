using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class Motion_Attacking : StateMachineBehaviour
{
    InputReader inputReader = new KeyboardMouseInput();
    public bool isCombo;
    [Range(0f, 1f)]
    public float normalizedTime;
    [MinMaxSlider(0f, 1f)]
    public Vector2 selectedNormalizedTime;
    public int comboNum;
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        isCombo = false;
        animator.SetBool("Attack", false);
    }


    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (inputReader.GetLightAttackButton())
        {
            isCombo = true;
            animator.SetBool("Attack", true);
        }
        if (stateInfo.normalizedTime >= selectedNormalizedTime.x && stateInfo.normalizedTime <= selectedNormalizedTime.y)
        {

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
