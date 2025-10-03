using UnityEngine;
using System.Collections.Generic;


[CreateAssetMenu(fileName = "Novo Tema", menuName = "Quiz/Novo Tema")]
public class ThemeSO : ScriptableObject
{
    public string themeName; 
    public List<Question> questions = new List<Question>(); 
}