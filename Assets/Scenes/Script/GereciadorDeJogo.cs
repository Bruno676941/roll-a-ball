using UnityEngine;
using TMPro;

public class GereciadorDeJogo : MonoBehaviour

{
    public static GereciadorDeJogo instancia;
    
    public TextMeshProUGUI  TextoPontuacao;

    private int pontuacao = 0;

    void Awake()
    {
        instancia = this;
    }
    
    void Start()
    {
       AtualizarTexto();
    }
    public void AdicionarPontos(int quantidade)
    {
        pontuacao += quantidade;
        AtualizarTexto();

    }

    void AtualizarTexto()
    {
        TextoPontuacao.text = "Pontuação: " + pontuacao;
    }

    
}
