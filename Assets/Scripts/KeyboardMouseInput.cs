using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardMouseInput : InputReader
{
    public KeyCode lightAttack;
    public KeyCode heavyAttack;
    public KeyCode dodge;
    public KeyCode jump;

    public override bool HasMovementInput()
    {
        var vector2 = GetAxis();
        return Mathf.Abs(vector2.x) > 0 ||  Mathf.Abs(vector2.y) > 0;
    }

    public override Vector2 GetAxis()
    {
        return new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }

    public override bool GetRollButton()
    {
        return Input.GetKey(KeyCode.LeftShift);
    }

    public override bool GetJumpButton()
    {
        return Input.GetKey(KeyCode.Space);
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

    public override bool GetLightAttackButton()
    {
        return Input.GetMouseButton(0);
    }

    public override bool GetStartButton()
    {
        return base.GetStartButton();
    }

    public override bool GetTouchpad()
    {
        return base.GetTouchpad();
    }

    public override bool GetHeavyAttackButton()
    {
        return Input.GetButton("Jump");
    }
}
