using UnityEngine;

public class BuildingTile : MonoBehaviour
{
    public AudioClip stepSound;

    public void Start()
    {
        PlayStepSound();
    }

    private void PlayStepSound()
    {
        AudioManager.Instance.PlaySound(gameObject, stepSound, 0.2f);
    }
}
