using UnityEngine;

[System.Serializable]
public class Question
{
    [TextArea(3, 10)] 
    public string questionText; 

    public string[] answers; 

    public int correctAnswerIndex;
}