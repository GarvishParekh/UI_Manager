using UnityEngine;

public class GeneralPopAnimation : MonoBehaviour, ICanvasAnimation
{
    [SerializeField] private CanvasGroup dimmerCG;
    [SerializeField] private CanvasGroup mainCG;


    public void ResetAnimation()
    {
        dimmerCG.alpha = 0;
        mainCG.alpha = 0;
        mainCG.transform.localScale = Vector3.one * 1.3f;
    }

    public void StartAnimation()
    {
        ResetAnimation();
        LeanTween.alphaCanvas(dimmerCG, 1, 0.25f).setEaseInOutSine().setOnComplete(() =>
        {
            LeanTween.alphaCanvas(mainCG, 1, 0.25f).setEaseInOutSine();
            LeanTween.scale(mainCG.gameObject, Vector3.one, 0.25f).setEaseInOutSine();
        });
    }
}
