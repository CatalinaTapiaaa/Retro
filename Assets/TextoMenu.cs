using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextoMenu : MonoBehaviour
{
    public GameObject componente;
    public Puntuacion score;

    public TextMeshProUGUI puntuacionMaximaTexto;

    void Update()
    {
        componente = GameObject.Find("PUNTAJE CONTROLER");
        score = componente.GetComponent<Puntuacion>();

        puntuacionMaximaTexto.text = score.puntuacionMaxima.ToString("00000");
    }
}
