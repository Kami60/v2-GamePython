using UnityEngine;
using UnityEngine.SceneManagement;

public class comandosBasicos : MonoBehaviour
{

    public static comandosBasicos instance;

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
    public void CarregarCena(string nomeCena)
    {
        SceneManager.LoadScene(nomeCena);
    }
}
