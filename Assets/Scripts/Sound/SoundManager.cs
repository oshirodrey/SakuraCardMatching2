using UnityEngine;

public class SoundManager : MonoBehaviour
{
    // The static instance that any script can access
    public static SoundManager Instance { get; private set; }

    [SerializeField] private AudioSource MusicSource;
    [SerializeField] private AudioSource SFXSource;

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
    public void PlaySFX(AudioClip clip)
    {
        if (clip != null && SFXSource != null)
        {
            SFXSource.PlayOneShot(clip);
        }
    }
    public void StopSFX()
    {
        if (SFXSource != null)
        {
            SFXSource.Stop();
        }
    }

    public void PlayMusic(AudioClip clip)
    {
        if (clip != null && MusicSource != null)
        {
            MusicSource.clip = clip;
            MusicSource.Play();
        }
    }

    public void StopMusic()
    {
        if (MusicSource != null)
        {
            MusicSource.Stop();
        }
    }

    
}