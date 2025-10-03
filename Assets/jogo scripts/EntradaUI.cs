using UnityEngine;

public class EntradaUI : MonoBehaviour
{
    public void SelectThemeAndPlay(ThemeSO theme)
    {
        GameManager.instance.selectedTheme = theme;


        SceneLoader.instance.LoadNextThemeScene();
    }

    public void OnVoltarButtonPressed()
    {
        SceneLoader.instance.LoadMainMenuScene();
    }
}