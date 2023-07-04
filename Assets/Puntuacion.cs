using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntuacion : MonoBehaviour
{
    public int puntuacion;
    public int puntuacionMaxima;
	private static bool created;

	public void Start()
	{
		if (created)
		{
			Destroy(gameObject);
			return;
		}

		DontDestroyOnLoad(gameObject);
		created = true;
	}

	private void Update()
	{
		if (puntuacion > puntuacionMaxima)
		{
			puntuacionMaxima = puntuacion;
		}
	}

	private void Load()
    {
		if (PlayerPrefs.HasKey("PuntuacionMaxima"))
		{
			puntuacionMaxima = PlayerPrefs.GetInt("PuntuacionMaxima");
		}
    }

}

