using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MovimientoEnemigo : MonoBehaviour
{
    private Rigidbody2D _compRigidbody2D;
    private SpriteRenderer _compSpriteRenderer;

    public float velocidadX;
    public float velocidadY;
    public int direccionX;
    public int direccionY;

    protected float vida;
    public
        float daño;

    public BalaControl baladamage;

    void Awake()
    {
        _compRigidbody2D = GetComponent<Rigidbody2D>();
        _compSpriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        vida = 5;
        daño = 3;
        velocidadX = Random.Range(400f, 500f);
    }
    public float Daño()
    {
        
       return daño;
    }

    public float GetVida()
    {
        return vida;
    }


    public void SetVida(int value)
    {
        vida = value;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("VERTICAL"))
        {
            if (direccionX == 1)
            {
                direccionX = -1;
                _compSpriteRenderer.flipX = true;
            }
            else if (direccionX == -1)
            {
                direccionX = 1;
                _compSpriteRenderer.flipX = false;
            }
            

        }

        if (collision.gameObject.CompareTag("HORIZONTAL"))
        {
            if (direccionY == 1)
            {
                direccionY = -1;

            }
            else if (direccionY == -1)
            {
                direccionY = 1;

            }   
        }
        if (collision.gameObject.CompareTag("Bala"))
        {
            vida = vida - baladamage.dañoBala;
        }

        if (vida <= 0)
        {
            Destroy(this.gameObject);
        }


    }

    

    void FixedUpdate()
    {
        _compRigidbody2D.velocity = new Vector2(velocidadX * direccionX * Time.deltaTime, velocidadY * direccionY * Time.deltaTime);
    }

}
