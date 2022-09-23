using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteractable
{
    int GetPriority();
    void WithinArea();
    void InteractSprite();
    void InteractSound();
    void Interact();
    void Disconnect();
}
