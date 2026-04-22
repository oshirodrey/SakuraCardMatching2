using UnityEngine;


public class MainMenuController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void openModeSelectScene(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("ModeChoosing(sing-mul)");
        
    }
    public void openSettingsScene(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("Settings");
    }
    public void openRulesScene(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("Rules");
    }
    public void openHighScoreScene(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("HighScores");
    }
    public void exitGame(){
        Application.Quit();
    }

    public void openMainMenuScene(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }

    public void openSinglePlayerScene(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("Singleplayer");
    }

}
