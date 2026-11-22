
using UnityEngine;

public readonly struct PlaySettings
{
    public readonly float Volume;
    public readonly float VolumeVariation;
    public readonly float Pitch;
    public readonly float PitchVariation;

    public PlaySettings(float volume, float pitch,float volumeVariation = 0,float pitchVariation = 0)
    {
        Volume = volume;
        VolumeVariation = volumeVariation;
        Pitch = pitch;
        PitchVariation = pitchVariation;
    }
}
public class AudioManager : MonoBehaviour
{
    public AudioSource musicSource;
    public static AudioManager Instance;
    private void Awake()
    {
        Instance = this;
    }

    public void PlayMusic(AudioClip music)
    {
        musicSource.clip = music;
        musicSource.Play();
    }
    public void PlaySound(GameObject target, AudioClip sound, PlaySettings playSettings)
    {
        var soundSource = target.AddComponent<AudioSource>();
        soundSource.clip = sound;
        soundSource.volume = Random.Range(playSettings.Volume - playSettings.VolumeVariation, playSettings.Volume + playSettings.VolumeVariation);
        soundSource.pitch = Random.Range(playSettings.Pitch - playSettings.PitchVariation, playSettings.Pitch + playSettings.PitchVariation);
        soundSource.Play();
        Destroy(soundSource,sound.length);
    }

}
