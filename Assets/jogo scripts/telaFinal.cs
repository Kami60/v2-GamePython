using UnityEngine;
using UnityEngine.UI;

public class TelaFinal : MonoBehaviour
{
    public Button btnRepetir;
    public Button btnMenu;
    public Button btnInicio;

    private void Start()
    {
        // Remove eventos antigos (caso a cena seja carregada mais de uma vez)
        btnRepetir.onClick.RemoveAllListeners();
        btnMenu.onClick.RemoveAllListeners();
        btnInicio.onClick.RemoveAllListeners();

        // Configura os botões com os nomes corretos das cenas
        btnRepetir.onClick.AddListener(() => comandosBasicos.instance.CarregarCena("tema1"));
        btnMenu.onClick.AddListener(() => comandosBasicos.instance.CarregarCena("entrada"));
        btnInicio.onClick.AddListener(() => comandosBasicos.instance.CarregarCena("titulo"));
    }
}