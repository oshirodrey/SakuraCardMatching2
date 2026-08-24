using UnityEngine;
using UnityEngine.EventSystems; // You need this namespace for UI hover events!

// IPointerEnterHandler is the interface that detects when the mouse enters the UI element
public class HoverButtonSound : MonoBehaviour, IPointerEnterHandler
{
    [SerializeField] private AudioClip hoverSound;

    // This function triggers the exact moment your mouse touches the button
    public void OnPointerEnter(PointerEventData eventData)
    {
        // Check if we have a sound and if our SoundManager exists
        if (hoverSound != null && SoundManager.Instance != null)
        {
            SoundManager.Instance.PlaySfx(hoverSound);
        }
    }
}