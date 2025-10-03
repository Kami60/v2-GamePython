using UnityEngine;


public class GameManager : MonoBehaviour
{
   
    public static GameManager instance;

    public ThemeSO selectedTheme;

    public int finalScore;
    public int correctAnswers;
    public int totalQuestions;

   
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
}