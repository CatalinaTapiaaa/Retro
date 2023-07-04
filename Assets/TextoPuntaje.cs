using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextoPuntaje : MonoBehaviour
{
    public GameObject componente;
    public Puntuacion score;

    public TextMeshProUGUI puntuacionTexto;
    public TextMeshProUGUI puntuacionMaximaTexto;

	void Update()
    {
        componente = GameObject.Find("PUNTAJE CONTROLER");
        score = componente.GetComponent<Puntuacion>();

        puntuacionTexto.text = score.puntuacion.ToString("00000");
        puntuacionMaximaTexto.text = score.puntuacionMaxima.ToString("00000");
    }
}
