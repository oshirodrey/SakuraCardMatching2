using UnityEngine;
using UnityEngine.UI;

public class AudioSliderSync : MonoBehaviour
{
    [SerializeField] private Slider masterSlider;
    [SerializeField] private Slider musicSlider;
    [SerializeField] private Slider sfxSlider;



    private void Start()
    {
        // Connect the sliders via code to the guaranteed living Instance
        if (masterSlider != null)
            masterSlider.onValueChanged.AddListener(SoundManager.Instance.AdjustMasterVolume);

        if (musicSlider != null)
            musicSlider.onValueChanged.AddListener(SoundManager.Instance.AdjustMusicVolume);

        if (sfxSlider != null)
            sfxSlider.onValueChanged.AddListener(SoundManager.Instance.AdjustSfxVolume);
    }

    private void OnEnable()
    {
        // SetValueWithoutNotify changes the handle position but DOES NOT fire the 
        // "On Value Changed" event, which stops it from constantly saving to PlayerPrefs 
        // every single time you open the settings menu.
        if (masterSlider != null)
            masterSlider.SetValueWithoutNotify(PlayerPrefs.GetFloat("MasterVolume", SoundManager.Instance.GetMasterVolume()));

        if (musicSlider != null)
            musicSlider.SetValueWithoutNotify(PlayerPrefs.GetFloat("MusicVolume", SoundManager.Instance.GetMusicVolume()));

        if (sfxSlider != null)
            sfxSlider.SetValueWithoutNotify(PlayerPrefs.GetFloat("SFXVolume", SoundManager.Instance.GetSFXVolume()));
    }
}
