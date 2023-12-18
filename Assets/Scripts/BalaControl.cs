using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaControl : MonoBehaviour
{
    public float velocidadBala;
    public float dañoBala;
    public MovimientoEnemy vidaboss;

    
    void Update()
    {
        transform.Translate(Vector2.up * velocidadBala * Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("VERTICAL"))
        {
            Destroy(this.gameObject);
        }
        else if (collision.gameObject.CompareTag("HORIZONTAL"))
        {
            Destroy(this.gameObject);
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(this.gameObject);
        }
        else if (collision.gameObject.CompareTag("Enemy2"))
        {
            Destroy(this.gameObject);
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(this.gameObject);
        }
        else if (collision.gameObject.CompareTag("BOSS"))
        {
            Destroy(this.gameObject);
        }
    }

    
}
