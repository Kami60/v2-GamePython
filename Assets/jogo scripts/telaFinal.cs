using UnityEngine;
using UnityEngine.UI;

public class TelaFinal : MonoBehaviour
{
    public Button btnRepetir;
    public Button btnMenu;
    public Button btnInicio;

    private void Start()
    {
        
        btnRepetir.onClick.RemoveAllListeners();
        btnMenu.onClick.RemoveAllListeners();
        btnInicio.onClick.RemoveAllListeners();

        
        btnRepetir.onClick.AddListener(() => comandosBasicos.instance.CarregarCena("tema1"));
        btnMenu.onClick.AddListener(() => comandosBasicos.instance.CarregarCena("entrada"));
        btnInicio.onClick.AddListener(() => comandosBasicos.instance.CarregarCena("titulo"));
    }
}