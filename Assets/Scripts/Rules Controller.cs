using UnityEngine;

public class RulesController : MonoBehaviour
{
    [SerializeField] private AudioClip backgroundMusic;
    void Start()
    {
     SoundManager.Instance.PlayMusic(backgroundMusic);       
    }

}
