using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Animacion : MonoBehaviour
{
	public Animator ani;

	private IEnumerator AnimacionSalida()
	{

		yield return null;
		SceneManager.LoadScene(0);
	}

	private IEnumerator AnimacionEntrada()
	{

		yield return null;
		SceneManager.LoadScene(1);
	}
}
