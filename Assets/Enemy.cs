using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int vida;
    public int puntos;

    public GameObject componente;
    public Puntuacion score;

    void Update()
    {
        componente = GameObject.Find("PUNTAJE CONTROLER");
        score = componente.GetComponent<Puntuacion>();

        if (vida <= 0)
		{
            score.puntuacion += puntos;
            Destroy(gameObject);
		}
    }

	private void OnTriggerEnter2D(Collider2D collision)
	{
        if (collision.CompareTag("Bala"))
        {
            vida -= 1;
        }
    }
}

