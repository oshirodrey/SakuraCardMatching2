using UnityEngine;

public class ScreenResSetter : MonoBehaviour
{
    [Header("Scene Resolution Settings")]
    public int windowWidth = 800;
    public int windowHeight = 600;

    void Start()
    {
        // When this scene loads, snap the window to these dimensions
        Screen.SetResolution(windowWidth, windowHeight, FullScreenMode.Windowed);
    }
}
