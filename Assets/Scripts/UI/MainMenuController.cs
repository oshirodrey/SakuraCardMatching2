using Unity.VisualScripting;
using UnityEngine;


public class MainMenuController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    [SerializeField] private AudioClip buttonClickSound;

   // [SerializeField] private AudioClip buttonHoverSound;
    [SerializeField] private AudioClip backgroundMusic;

    [SerializeField] private GameObject choosingPlayModePanel;
    
    void Start()
    {
        SoundManager.Instance.PlayMusic(backgroundMusic);
    }

    void PlayButtonClickSound()
    {
        SoundManager.Instance.PlaySFX(buttonClickSound);
    
    }

    public void loadSceneByName(string sceneName){
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
        PlayButtonClickSound();
        SoundManager.Instance.StopMusic();
    }

    public void showChoosingPlayModePanel(){
        choosingPlayModePanel.SetActive(true);
        PlayButtonClickSound();
    }

    public void hideChoosingPlayModePanel(){
        choosingPlayModePanel.SetActive(false);
        PlayButtonClickSound();
    }
 
    public void exitGame(){
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        Application.Quit();
        #endif
    }


    

}
