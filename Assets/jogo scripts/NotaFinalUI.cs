using UnityEngine;
using TMPro; 

public class NotaFinalUI : MonoBehaviour
{
    [Header("Referências de UI")]
    public TextMeshProUGUI scoreText; 
    public TextMeshProUGUI summaryText; 
    public GameObject[] stars; 

    void Start()
    {
       
        int score = GameManager.instance.finalScore;
        int correct = GameManager.instance.correctAnswers;
        int total = GameManager.instance.totalQuestions;

       
        scoreText.text = score.ToString();
        summaryText.text = $"Você acertou {correct} de {total} perguntas";

     
        UpdateStars(correct, total);
    }

    void UpdateStars(int correctAnswers, int totalQuestions)
    {
       
        foreach (var star in stars)
        {
            star.SetActive(false);
        }

       
        float percentage = (float)correctAnswers / totalQuestions;

       
        if (percentage >= 0.9f) 
        {
            stars[0].SetActive(true);
            stars[1].SetActive(true);
            stars[2].SetActive(true);
        }
        else if (percentage >= 0.5f)
        {
            stars[0].SetActive(true);
            stars[1].SetActive(true);
        }
        else if (correctAnswers > 0) 
        {
            stars[0].SetActive(true);
        }
    }


    public void OnReplayButtonPressed()
    {
       
        SceneLoader.instance.LoadNextThemeScene();
    }


    public void OnThemesButtonPressed()
    {
        
        SceneLoader.instance.LoadGameScene();
    }

  
    public void OnHomeButtonPressed()
    {
      
        SceneLoader.instance.LoadMainMenuScene();
    }
}