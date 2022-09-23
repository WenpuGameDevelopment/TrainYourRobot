using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InputReader : MonoBehaviour
{

    public virtual bool GetAxis(out Vector2 vector2)
    {
        throw new NotImplementedException();
    }

    public virtual bool GetCrossButton()
    {
        throw new NotImplementedException();
    }

    public virtual bool GetCircleButton()
    {
        throw new NotImplementedException();
    }

    public virtual bool GetTriangleButton()
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

    public virtual bool GetSquareButton()
    {
        throw new NotImplementedException();
    }
}
