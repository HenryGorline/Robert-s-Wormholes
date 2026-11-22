using System;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public AudioClip stepSound;
    

    private void PlayStepSound()
    {
        AudioManager.Instance.PlaySound(gameObject, stepSound, new PlaySettings(1,1,1,0.4f));
    }
}
