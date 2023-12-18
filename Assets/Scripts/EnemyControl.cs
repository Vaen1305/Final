using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    public float speedX;
    public float speedY;
    private float directionX = -1;
    private float directionY = 1;
    private Rigidbody2D _compRigidbody;
    private SpriteRenderer _compSpriteRenderer;

    void Awake()
    {
        _compRigidbody = GetComponent<Rigidbody2D>();
        _compSpriteRenderer = GetComponent<SpriteRenderer>();
    }

    void FixedUpdate()
    {
        _compRigidbody.velocity = new Vector2(speedX * directionX, speedY * directionY);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "MuroX")
        {
            if (directionX == -1)
            {
                directionX = 1;
                _compSpriteRenderer.flipX = true;
            }
            else if (directionX == 1)
            {
                directionX = -1;
                _compSpriteRenderer.flipX = false;
            }
        }
        if (collision.gameObject.tag == "MuroY")
        {
            if (directionY == 1)
            {
                directionY = -1;
                _compSpriteRenderer.flipY = true;
            }
            else if (directionY == -1)
            {
                directionY = 1;
                _compSpriteRenderer.flipY = false;
            }
        }
    }
}
