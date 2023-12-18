using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed;
    private Rigidbody2D _compRigidbody;
    private Animator _compAnimator;
    public GameObject bulletPrefab;
    public float vidaj;
    public float da�oActual;
    public int balasRestantes = 5;
    private float tiempoEspera = 0.75f;
    private bool recargando = false;
    
    private void Awake()
    {
        _compRigidbody = GetComponent<Rigidbody2D>();
        _compAnimator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        Vector2 movimiento = new Vector2(movimientoHorizontal, movimientoVertical);
        _compRigidbody.velocity = movimiento * speed;
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.A) == true)
        {
            _compAnimator.SetBool("Caminar",true);
        }
        else if(Input.GetKey(KeyCode.S) == true)
        {
            _compAnimator.SetBool("Caminar", true);
        }
        else if( Input.GetKey(KeyCode.D) == true)
        {
            _compAnimator.SetBool("Caminar", true);

        }
        else if(Input.GetKey(KeyCode.W) == true)
        {
            _compAnimator.SetBool("Caminar", true);
        }
        else if(Input.GetMouseButton(0) == true)
        {
            _compAnimator.SetBool("Disparar",true);
            _compAnimator.SetBool("Caminar", false);
        }
        else if ((Input.GetMouseButton(0) == false))
        {
            _compAnimator.SetBool("Caminar", false);
            _compAnimator.SetBool("Disparar", false);
        }
       
                  Vector3 mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

            Vector2 direction = new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);

            transform.up = direction;

            if (Input.GetMouseButtonDown(0))
            {
                Disparar();
            }
        

    }
    void Disparar()
    {
        if (balasRestantes > 0 && !recargando)
        {
           
            Instantiate(bulletPrefab, transform.position, transform.rotation);

            
            balasRestantes--;

            
            if (balasRestantes == 0)
            {
               
                recargando = true;
                Invoke("RecargarBalas", tiempoEspera);
            }
        }
    }

    void RecargarBalas()
    {
        
        balasRestantes = 5;

     
        recargando = false;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        MovimientoEnemigo enemigo = collision.GetComponent<MovimientoEnemigo>();
        MovementAnddamage1 enemigo2 = collision.GetComponent<MovementAnddamage1>();
        MovimientoEnemy boss = collision.GetComponent<MovimientoEnemy>();
        HerenciadePwer powerUp = collision.GetComponent<HerenciadePwer>();

        if (enemigo != null)
        {
            vidaj -= enemigo.da�o;
        }

        if (enemigo2 != null)
        {
            vidaj -= enemigo2.da�o;
        }
        if (boss != null)
        {
            vidaj -= boss.da�o;
        }
        if (collision.gameObject.CompareTag("Pistola"))
        {
            Destroy(collision.gameObject);

            if (powerUp != null && powerUp is Da�opistola)
            {
                ((Da�opistola)powerUp).ApplyPowerUp(this);
            }
        }
        if (collision.gameObject.CompareTag("Scopeta"))
        {
            Destroy(collision.gameObject);

            if (powerUp != null && powerUp is Da�oScopeta)
            {
                ((Da�oScopeta)powerUp).ApplyPowerUp(this);
            }
        }
        if (collision.gameObject.CompareTag("CuraVerde"))
        {
            Destroy(collision.gameObject);

            if (powerUp != null && powerUp is CuraVerde)
            {
                ((CuraVerde)powerUp).ApplyPowerUp(this);
            }
        }
        if (collision.gameObject.CompareTag("CuraRoja"))
        {
            Destroy(collision.gameObject);

            if (powerUp != null && powerUp is CuraRojo)
            {
                ((CuraRojo)powerUp).ApplyPowerUp(this);
            }
        }
    }

    public void AumentarVida(float aumento)
    {
        vidaj += aumento;

    }
    public void AumentarDa�o(float aumento)
    {
        da�oActual += aumento;
    }
}

