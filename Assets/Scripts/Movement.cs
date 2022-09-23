using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private InputReader inputReader;

    private void Awake()
    {
        inputReader = GetComponent<InputReader>();
    }
    private void FixedUpdate()
    {
        if(inputReader.GetAxis(out Vector2 vector2))
        {

        }
        if (inputReader.GetCrossButton())
        {

        }
        if (inputReader.GetSquareButton())
        {

        }
        if (inputReader.GetCircleButton())
        {

        }
        if (inputReader.GetTriangleButton())
        {

        }
        if (inputReader.GetR1Button())
        {

        }
        if (inputReader.GetR2Button())
        {

        }
        if (inputReader.GetR3Button())
        {

        }
        if (inputReader.GetL1Button())
        {

        }
        if (inputReader.GetL2Button())
        {

        }
        if (inputReader.GetL3Button())
        {

        }
        if (inputReader.GetStartButton())
        {

        }
        if (inputReader.GetOptionButton())
        {

        }
        if (inputReader.GetTouchpad())
        {

        }
    }
}
