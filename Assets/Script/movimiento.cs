using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    Rigidbody2D rigid;

    [SerializeField] float jumpForce;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void Jump()
    {
        rigid.velocity = new Vector2(0, jumpForce);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Respawn"))
        {
            Controlador_Juego.Instania.FinJuego();
        }

    }
}
