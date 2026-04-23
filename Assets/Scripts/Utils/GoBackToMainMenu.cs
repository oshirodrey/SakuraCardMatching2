using UnityEngine;

public class GoBackToMainMenu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void goBackToMainMenu(){
        SoundManager.Instance.StopMusic();
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }
}
