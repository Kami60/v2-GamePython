using UnityEngine;

public class MainMenuUI : MonoBehaviour
{
    public void OnPlayButtonPressed()
    {

        SceneLoader.instance.LoadGameScene();
    }

    public void OnQuitButtonPressed()
    {
        SceneLoader.instance.QuitGame();
    }
}