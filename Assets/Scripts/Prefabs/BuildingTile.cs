using System;
using UnityEngine;

public class BuildingTile : MonoBehaviour
{
    public AudioClip stepSound;

    private void Start()
    {
        AudioManager.Instance.PlayMusic(stepSound);
    }

    private void PlayStepSound()
    {
        AudioManager.Instance.PlaySound(gameObject, stepSound, new PlaySettings(1,1,1,0.4f));
    }
}
