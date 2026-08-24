using UnityEngine;
using UnityEngine.Serialization;

public class SoundManager : MonoBehaviour
{
    // The static instance that any script can access
    public static SoundManager Instance { get; private set; }

    [FormerlySerializedAs("MusicSource")]
    [Header("Audio Sources")]
    [SerializeField] private AudioSource musicSource;
    [SerializeField] private AudioSource SFXSource;
    
    [Header("Volume Settings")]
    [Range(0f, 1f)] private float _masterVolume = 1f;
    [Range(0f, 1f)] private float _musicVolume = 0.5f;
    [Range(0f, 1f)] private float _sfxVolume = 0.5f;

    private void Awake()
    {
        // Check if an instance already exists
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject); // Destroy duplicates
            return;
        }

        Instance = this;
        // Keep this manager alive even when you change scenes!
        DontDestroyOnLoad(this.gameObject); 
    }

    // Now any script can call this by passing in an AudioClip
    public void PlaySfx(AudioClip clip)
    {
        if (clip != null && SFXSource != null)
        {
            SFXSource.PlayOneShot(clip);
        }
    }
    public void StopSfx()
    {
        if (SFXSource != null)
        {
            SFXSource.Stop();
        }
    }

    public void PlayMusic(AudioClip clip)
    {
        if (clip != null && musicSource != null)
        {
            musicSource.clip = clip;
            musicSource.Play();
        }
    }

    public void StopMusic()
    {
        if (musicSource != null)
        {
            musicSource.Stop();
        }
    }

    
    private void UpdateAudioSources()
    {
        // The final volume is the individual volume multiplied by the master volume
        musicSource.volume = _musicVolume * _masterVolume;
        SFXSource.volume = _sfxVolume * _masterVolume;
    }

    public void AdjustMasterVolume(float value)
    {
        _masterVolume= value;
        UpdateAudioSources();
    }

    public void AdjustMusicVolume(float value)
    {
        if (musicSource != null)
        {
            _musicVolume = value;
            UpdateAudioSources();
        }
        
    }

    public void AdjustSfxVolume(float value)
    {
        if (SFXSource != null)
        {
            _sfxVolume = value;
            UpdateAudioSources();
        }
    }
    
    
    public float GetMasterVolume()
    {
        return _masterVolume;
    }

    public float GetMusicVolume()
    {
        return _musicVolume;
    }

    public float GetSFXVolume()
    {
        return _sfxVolume;
    }
}