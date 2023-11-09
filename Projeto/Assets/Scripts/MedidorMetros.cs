using UnityEngine;
using TMPro;

public class MedidorMetros : MonoBehaviour
{
    public GameObject jogador;  // jogador
    public GameObject objetoDeColisao; //colisão que reiniciará o timer
    public float velocidadeContador = 1.0f; 
    private float metrosPercorridos = 0f; 
    private bool timerAtivo = true;

    public TMP_Text distanciaText;

    void Update()
    {
        if (timerAtivo)
        {
            metrosPercorridos += Time.deltaTime * velocidadeContador; 
        }

        int metrosArredondados = Mathf.RoundToInt(metrosPercorridos); // arredonda para inteiro
        distanciaText.text = metrosArredondados.ToString() + "m";

        if (jogador != null && objetoDeColisao != null)
        {
            if (Vector3.Distance(jogador.transform.position, objetoDeColisao.transform.position) < 1f)
            {
                ReiniciarMedidorDeMetros();
            }
        }
    }

    void ReiniciarMedidorDeMetros()
    {
        metrosPercorridos = 0f;
        timerAtivo = true;
    }
}
