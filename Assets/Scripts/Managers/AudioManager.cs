
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    private void Awake()
    {
        Instance = this;
    }

    public void PlaySound(GameObject target, AudioClip sound, float pitchVariation = 0, float volumeVariation = 0)
    {
        var source = target.AddComponent<AudioSource>();
        source.clip = sound;
        source.pitch = Random.Range(1 - pitchVariation, 1 + pitchVariation);
        source.volume = Random.Range(1 - volumeVariation, 1 + volumeVariation);
        source.Play();
        Destroy(source,sound.length);
    }

}
