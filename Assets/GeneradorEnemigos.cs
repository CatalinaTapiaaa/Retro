using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorEnemigos : MonoBehaviour
{
	public float tiempo;
	public GameObject enemigo;

	private void Start()
	{
		StartCoroutine(Rutina(tiempo));
	}

	private IEnumerator Rutina(float seconds)
	{
		while (true)
		{
			Instantiate(enemigo, transform.position, Quaternion.identity);
			yield return new WaitForSeconds(seconds);
		}
	}

}
