using UnityEngine;
using UnityEngine.UI; 
using TMPro; 
using System.Collections.Generic;

public class QuizManager : MonoBehaviour
{
    
    [Header("Referências de UI")]
    public TextMeshProUGUI questionText; 
    public Button[] answerButtons;

    [Header("Dados do Quiz")]
    public ThemeSO currentTheme;

    
    private List<Question> questions;
    private int currentQuestionIndex = 0;
    private int score = 0;


    private int correctAnswersCount = 0;

    void Start()
    {
        
        currentTheme = GameManager.instance.selectedTheme;

        
        questions = new List<Question>(currentTheme.questions);

        
        Shuffle(questions);

        
        ShowQuestion();
    }

    void ShowQuestion()
    {
       
        if (currentQuestionIndex >= questions.Count)
        {
            EndQuiz();
            return;
        }

        
        Question currentQuestion = questions[currentQuestionIndex];

     
        questionText.text = currentQuestion.questionText;

        for (int i = 0; i < answerButtons.Length; i++)
        {
            
            answerButtons[i].onClick.RemoveAllListeners();
            answerButtons[i].GetComponentInChildren<TextMeshProUGUI>().text = currentQuestion.answers[i];

            int buttonIndex = i;
            answerButtons[i].onClick.AddListener(() => OnAnswerSelected(buttonIndex));
        }
    }

    void OnAnswerSelected(int selectedIndex)
    {
        Question currentQuestion = questions[currentQuestionIndex];

       
        if (selectedIndex == currentQuestion.correctAnswerIndex)
        {
            Debug.Log("Resposta Correta!");
            score += 10; 
            correctAnswersCount++;
        }
        else
        {
            Debug.Log("Resposta Incorreta!");
        }

       
        currentQuestionIndex++;
        ShowQuestion();
    }

    void EndQuiz()
    {
        Debug.Log($"Quiz finalizado! Sua pontuação: {score}");
        GameManager.instance.finalScore = score;
        GameManager.instance.correctAnswers = correctAnswersCount;
        GameManager.instance.totalQuestions = questions.Count;

        SceneLoader.instance.LoadFinalScoreScene();
    }

    void Shuffle<T>(List<T> list)
    {
        for (int i = 0; i < list.Count - 1; i++)
        {
            int rnd = Random.Range(i, list.Count);
            T temp = list[rnd];
            list[rnd] = list[i];
            list[i] = temp;
        }
    }
}