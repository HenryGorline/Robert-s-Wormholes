using System;
using UnityEngine;

public class BuildingTile : MonoBehaviour
{
    public AudioClip stepSound;
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayStepSound();
        }
    }

    private void PlayStepSound()
    {
        AudioManager.Instance.PlaySound(gameObject, stepSound, new SoundSettings(1,1,1,0.4f));
    }
}
