using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
	public Animator ani;

	public void Start()
	{
		ani = GetComponent<Animator>();
		DontDestroyOnLoad(gameObject);
	}

	public void Menu()
	{
		StartCoroutine(AnimacionSalida());
		
	}
	public void NewGame()
	{
		StartCoroutine(AnimacionEntrada());
	}

	private IEnumerator AnimacionSalida()
	{
		ani.SetBool("On", true);
		yield return new WaitForSeconds(1);
		SceneManager.LoadScene(0);
		ani.SetBool("On", false);
	}

	private IEnumerator AnimacionEntrada()
	{
		ani.SetBool("On", true);
		yield return new WaitForSeconds(1);
		SceneManager.LoadScene(1);
		ani.SetBool("On", false);
	}
}
