
using UnityEngine;

public readonly struct SoundSettings
{
    public readonly float Volume;
    public readonly float VolumeVariation;
    public readonly float Pitch;
    public readonly float PitchVariation;

    public SoundSettings(float volume, float pitch,float volumeVariation = 0,float pitchVariation = 0)
    {
        Volume = volume;
        VolumeVariation = volumeVariation;
        Pitch = pitch;
        PitchVariation = pitchVariation;
    }
}
public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    private void Awake()
    {
        Instance = this;
    }

    public void PlaySound(GameObject target, AudioClip sound, SoundSettings soundSettings)
    {
        var source = target.AddComponent<AudioSource>();
        source.clip = sound;
        source.volume = Random.Range(soundSettings.Volume - soundSettings.VolumeVariation, soundSettings.Volume + soundSettings.VolumeVariation);
        source.pitch = Random.Range(soundSettings.Pitch - soundSettings.PitchVariation, soundSettings.Pitch + soundSettings.PitchVariation);
        source.Play();
        Destroy(source,sound.length);
    }

}
