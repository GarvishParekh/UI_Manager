using UnityEngine;

[RequireComponent(typeof(CanvasGroup))]
public class CanvasIdentity : MonoBehaviour
{
    CanvasGroup canvasGroup;
    ICanvasAnimation canvasAnimation;

    [SerializeField] private CanvasName myCanvasName;

    private void Awake()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        canvasAnimation = GetComponent<ICanvasAnimation>();
    }

    public CanvasName GetCanvasName()
    {
        return myCanvasName;
    }

    public void OpenCanvas()
    {
        ResetCanvas();

        if (canvasAnimation != null)
        {
            canvasAnimation.StartAnimation();
        }
        canvasGroup.alpha = 1;
        canvasGroup.blocksRaycasts = true;
        canvasGroup.interactable = true;
    }

    public void CloseCanvas()
    {
        ResetCanvas();
    }

    public void ResetCanvas()
    {
        canvasGroup.alpha = 0;
        canvasGroup.blocksRaycasts = false;
        canvasGroup.interactable = false;
    }
}