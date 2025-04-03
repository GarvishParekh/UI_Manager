using UnityEngine;

public class GeneralSaleInAnimation : MonoBehaviour, ICanvasAnimation
{
    [Header("<size=12>Component")]
    [SerializeField] private CanvasGroup canvasGroup;

    [Header("<size=12>Values")]
    [SerializeField] private float fadeInDuration = 0.5f;
    [SerializeField] private float scaleDurarion = 1.0f;

    public void ResetAnimation()
    {
        canvasGroup.alpha = 0;
        canvasGroup.transform.localScale = Vector3.one * 1.2f;
    }

    public void StartAnimation()
    {
        ResetAnimation();
        LeanTween.scale(canvasGroup.gameObject, Vector3.one, scaleDurarion).setEaseInOutSine();
        LeanTween.alphaCanvas(canvasGroup, 1, fadeInDuration).setEaseInOutSine();
    }
}
