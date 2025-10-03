using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
   
    public static SceneLoader instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    
    private void Start()
    {
       
        if (SceneManager.GetActiveScene().name == "Initializer")
        {
            LoadMainMenuScene();
        }
    }

    // --- Funções Públicas para os Botões Chamarem ---

    public void LoadMainMenuScene()
    {
        SceneManager.LoadScene("titulo");
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene("entrada");
    }

    public void LoadNextThemeScene()
    {
        SceneManager.LoadScene("tema1");
    }
    public void LoadFinalScoreScene()
    {
        SceneManager.LoadScene("notaFinal");
    }

    public void QuitGame()
    {
        Debug.Log("QUIT GAME CALLED!"); // Mensagem para teste no editor
        Application.Quit();
    }
}