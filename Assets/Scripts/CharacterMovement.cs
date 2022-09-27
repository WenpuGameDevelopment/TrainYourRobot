using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] Animator anim;
    InputReader inputReader;
    Rigidbody rb;
    public float movementSpeed = 5f;
    private Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        if(!TryGetComponent(out anim))
        {
            anim = GetComponentInChildren<Animator>();
        }
        cam = Camera.main;
        rb = GetComponent<Rigidbody>();
        inputReader = new KeyboardMouseInput();
    }

    // Update is called once per frame
    void FixedUpdate()
    {


        anim.SetInteger("Move", inputReader.HasMovementInput() ? 1 : 0);

    }
}
