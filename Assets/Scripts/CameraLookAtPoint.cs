using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLookAtPoint : MonoBehaviour
{
    public Transform player;
    public Transform target;


    public void FixedUpdate()
    {
        if (player == null) return;
        if(target == null)
        {
            transform.position = player.position;
        }
        else
        {
            transform.position = ((player.position - target.position) / 2) + target.position;
        }
    }


}
