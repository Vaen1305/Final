using UnityEngine;

public class MovimientoEnemy : MonoBehaviour
{

    private Rigidbody2D _compRigidbody2D;
    private SpriteRenderer _compSpriteRenderer;

    public float velocidadX;
    public float velocidadY;
    public int direccionX;
    public int direccionY;

    protected float vida;
    public float daño;

    public SpawnEnemysBoing SpawnEnemy;
    public SpawEnemy2 SpawnEnemy2;

    public MaxiMiniEnemys maxEnemigospe;

    public BalaControl dañobala;
    
  



    private void Start()
    {
        vida  = 250;
        daño = 8;
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

            maxEnemigospe.MaxEnemy();

            if (maxEnemigospe.maxEnemy <= 30)
            {
                SpawnEnemy.CreateEnemy();
                SpawnEnemy2.CreateEnemy2();
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

            maxEnemigospe.MaxEnemy();

            if (maxEnemigospe.maxEnemy <= 30)
            {
                SpawnEnemy.CreateEnemy();
                SpawnEnemy2.CreateEnemy2();
            }
            
        }

        if (collision.gameObject.CompareTag("Bala"))
        {
           vida  = vida - dañobala.dañoBala;
           
        }
    }

    void Awake()
    {
        _compRigidbody2D = GetComponent<Rigidbody2D>();
        _compSpriteRenderer = GetComponent<SpriteRenderer>();
    }

    void FixedUpdate()
    {
        _compRigidbody2D.velocity = new Vector2(velocidadX * direccionX * Time.deltaTime, velocidadY * direccionY * Time.deltaTime);
    }

    void Update()
    {
        if (vida <= 0)
        {
            Destroy(this.gameObject);

        }
    }
}