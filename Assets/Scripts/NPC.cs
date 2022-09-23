using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour, IInteractable
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] string interactSprite;
    [SerializeField] InteractUI interactUI;

    public void Disconnect()
    {
        interactUI.HideUI();
    }

    public int GetPriority()
    {
        throw new System.NotImplementedException();
    }

    public void Interact()
    {
        interactUI.ShowUI();
    }

    public void InteractSound()
    {
        audioSource.Play();
    }

    public void InteractSprite()
    {
        throw new System.NotImplementedException();
    }

    public void WithinArea()
    {
        throw new System.NotImplementedException();
    }
}
