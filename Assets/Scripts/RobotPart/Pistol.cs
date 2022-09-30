using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : MonoBehaviour
{
    public InputReader inputReader;
    public float reloadTime = 5f;
    public float currentTime = 0f;
    public int maxBullet = 5;
    public int currentBullet = 0;

    private void Awake()
    {
        inputReader = new KeyboardMouseInput();
    }

    public void Update()
    {
        if (inputReader.GetLightAttackButton())
        {

        }
    }
}
