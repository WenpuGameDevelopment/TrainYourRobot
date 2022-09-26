using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    InputReader inputReader;
    Rigidbody rb;
    public float movementSpeed = 5f;
    private Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        rb = GetComponent<Rigidbody>();
        inputReader = new KeyboardMouseInput();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 direction = cam.transform.TransformDirection(inputReader.GetAxis().To3DMovementAxis());
        Debug.Log(direction);
        direction.y = 0;
        rb.velocity = direction * movementSpeed;
    }
}
