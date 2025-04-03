using UnityEngine;

public class GeneralFadeInAnimation : MonoBehaviour, ICanvasAnimation
{
    [Header ("<size=12>Component")]
    [SerializeField] private CanvasGroup canvasGroup;

    [Header("<size=12>Values")]
    [SerializeField] private float fadeInDuration = 0.5f; 

    public void ResetAnimation()
    {
        canvasGroup.alpha = 0;
    }

    public void StartAnimation()
    {
        ResetAnimation();
        LeanTween.alphaCanvas(canvasGroup, 1, fadeInDuration).setEaseInOutSine();
    }
}
