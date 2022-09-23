using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardMouseInput : InputReader
{
    public KeyCode lightAttack;
    public KeyCode heavyAttack;
    public KeyCode dodge;
    public KeyCode jump;

    public override bool GetAxis(out Vector2 vector2)
    {
        vector2 = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        return Mathf.Abs(vector2.x) + Mathf.Abs(vector2.y) == 0;
    }

    public override bool GetCircleButton()
    {
        return Input.GetButton("Fire3");
    }

    public override bool GetCrossButton()
    {
        return Input.GetButton("Fire2");
    }

    public override bool GetL1Button()
    {
        return base.GetL1Button();
    }

    public override bool GetL2Button()
    {
        return base.GetL2Button();
    }

    public override bool GetL3Button()
    {
        return base.GetL3Button();
    }

    public override bool GetOptionButton()
    {
        return base.GetOptionButton();
    }

    public override bool GetR1Button()
    {
        return base.GetR1Button();
    }

    public override bool GetR2Button()
    {
        return base.GetR2Button();
    }

    public override bool GetR3Button()
    {
        return base.GetR3Button();
    }

    public override bool GetSquareButton()
    {
        return Input.GetButton("Fire1");
    }

    public override bool GetStartButton()
    {
        return base.GetStartButton();
    }

    public override bool GetTouchpad()
    {
        return base.GetTouchpad();
    }

    public override bool GetTriangleButton()
    {
        return Input.GetButton("Fire4");
    }
}
