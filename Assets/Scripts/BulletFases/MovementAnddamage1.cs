using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementAnddamage1 : MonoBehaviour
{


    private Rigidbody2D _compRigidbody2D;
    private SpriteRenderer _compSpriteRenderer;

    public float velocidadX;
    public float velocidadY;
    public int direccionX;
    public int direccionY;

    
    public int daño;
    public int rebotes;


    void Start()
    {
        
        daño = 2;
        
    }
    public float Daño2()
    {
        return daño;
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

            rebotes ++;

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

            rebotes ++;

        }
        if (rebotes >= 4)
        {
            Destroy(this.gameObject);
        }

    }

   

    void Awake()
    {
        _compRigidbody2D = GetComponent<Rigidbody2D>();
        _compSpriteRenderer = GetComponent<SpriteRenderer>();
    }

    void FixedUpdate()
    {
        _compRigidbody2D.velocity = new Vector2(velocidadX * direccionX, velocidadY * direccionY);
    }

}
