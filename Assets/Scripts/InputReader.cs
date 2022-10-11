using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class InputReaderTool
{
    public static Vector3 To3DMovementAxis(this Vector2 vector2)
    {
        return new Vector3(vector2.x, 0f, vector2.y);
    }
}


public abstract class InputReader : MonoBehaviour
{
    public enum InputType { KeyboardMouse, PS4Controller }
    public InputType currentInputType = InputType.KeyboardMouse;

    public virtual bool HasMovementInput()
    {
        throw new NotImplementedException();
    }
    public virtual Vector2 GetAxis()
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

public static class ComponentTool
{
    public static T GetComponentInSelfOrParent<T>(this Component component)
    {
        if(component.TryGetComponent(out T t))
        {
            return t;
        }
        else
        {
            return component.GetComponentInParent<T>();
        }
    }
}
