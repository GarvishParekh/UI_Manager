using UnityEngine;
using System.Collections.Generic;

public class UiManager : MonoBehaviour
{
    public static UiManager instance;
    [SerializeField] private List<CanvasIdentity> AllCanvas = new List<CanvasIdentity>();
    [SerializeField] private List<CanvasIdentity> AllPopups = new List<CanvasIdentity>();

    private void Awake()
    {
        instance = this;
    }

    public void OpenCanvas (CanvasName desireCanvas)
    {
        foreach (var canvas in AllCanvas)
        {
            if (canvas.GetCanvasName() == desireCanvas)
            {
                canvas.OpenCanvas();
            }
            else canvas.CloseCanvas();
        }
    }

    public void CloseCanvas(CanvasName desireCanvas)
    {
        foreach (var canvas in AllCanvas)
        {
            if (canvas.GetCanvasName() == desireCanvas)
            {
                canvas.CloseCanvas();
            }
        }
    }

    public void OpenPopup(CanvasName desireCanvas)
    {
        foreach (var canvas in AllPopups)
        {
            if (canvas.GetCanvasName() == desireCanvas)
            {
                canvas.OpenCanvas();
            }
        }
    }

    public void ClosePopup(CanvasName desireCanvas)
    {
        foreach (var canvas in AllPopups)
        {
            if (canvas.GetCanvasName() == desireCanvas)
            {
                canvas.CloseCanvas();
            }
        }
    }
}
