using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb2D;
    public GameObject bala;
    public Transform puntero;
    public float velocidad;
    public int vida;
    float x;
    float y;

    void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bala, puntero.position, Quaternion.identity);
        }
        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {
        x = Input.GetAxisRaw("Horizontal");
        Vector3 input = new Vector2(x, 0);

        rb2D.MovePosition(transform.position + (input * Time.fixedDeltaTime * velocidad));     
    }

	private void OnCollisionEnter2D(Collision2D collision)
	{
        if (collision.gameObject.CompareTag("Enemy"))
		{
            vida -= 1;
        }
        if (collision.gameObject.CompareTag("Final"))
		{
            SceneManager.LoadScene(0);
        }
    }
}
