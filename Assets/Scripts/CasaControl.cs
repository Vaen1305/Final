using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class CasaControl : MonoBehaviour
{
    public int vida;
   
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            vida = vida - 5;
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("Enemy2"))
        {
            vida = vida - 10;
            Destroy(collision.gameObject);
        }
    }
}
