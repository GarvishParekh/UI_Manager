using UnityEngine;

public class MainMenuUiController : MonoBehaviour
{
    UiManager uiManager;

    private void Start()
    {
        uiManager = UiManager.instance;
        uiManager.OpenCanvas(CanvasName.C_MAINMENU);
    }

    public void ButtonMainMenu() => uiManager.OpenCanvas(CanvasName.C_MAINMENU);
    public void ButtonSettings() => uiManager.OpenCanvas(CanvasName.C_SETTINGS);
    public void ButtonShop() => uiManager.OpenCanvas(CanvasName.C_SHOP);
    public void ButtonQuit() => uiManager.OpenPopup(CanvasName.P_QUIT);
    public void ButtonCloseQuitWarning() => uiManager.ClosePopup(CanvasName.P_QUIT);
}
