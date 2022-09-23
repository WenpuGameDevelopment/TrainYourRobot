using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InputReader : MonoBehaviour
{
    public enum InputType { KeyboardMouse, PS4Controller }
    public InputType currentInputType = InputType.KeyboardMouse;
    public virtual bool GetAxis(out Vector2 vector2)
    {
        throw new NotImplementedException();
    }

    public virtual bool GetJumpButton()
    {
        throw new NotImplementedException();
    }

    public virtual bool GetRollButton()
    {
        throw new NotImplementedException();
    }

    public virtual bool GetHeavyAttackButton()
    {
        throw new NotImplementedException();
    }

    public virtual bool GetR2Button()
    {
        throw new NotImplementedException();
    }

    public virtual bool GetR3Button()
    {
        throw new NotImplementedException();
    }

    public virtual bool GetL2Button()
    {
        throw new NotImplementedException();
    }

    public virtual bool GetStartButton()
    {
        throw new NotImplementedException();
    }

    public virtual bool GetOptionButton()
    {
        throw new NotImplementedException();
    }

    public virtual bool GetL3Button()
    {
        throw new NotImplementedException();
    }

    public virtual bool GetL1Button()
    {
        throw new NotImplementedException();
    }

    public virtual bool GetTouchpad()
    {
        throw new NotImplementedException();
    }

    public virtual bool GetR1Button()
    {
        throw new NotImplementedException();
    }

    public virtual bool GetLightAttackButton()
    {
        throw new NotImplementedException();
    }
}
