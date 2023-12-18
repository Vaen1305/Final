using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBulletsEnemy : MonoBehaviour
{

    public GameObject targetGameObject; // Referencia al GameObject objetivo
    public GameObject BulletEnemyPrefab;
    public GameObject BulletEnemyPrefab2;
    public GameObject BulletEnemyPrefab3;
    public MovimientoEnemy vidaboss;
    void Start()
    {
        Invoke("CreateBullet", 2);
    }

    void CreateBullet()
    {
        float vida = vidaboss.GetVida();

        if (vida <= 250 && vida > 168)
        {
            Instantiate(BulletEnemyPrefab, transform.position, transform.rotation);
        }
        else if (vida < 168 && vida > 84)
        {
            Instantiate(BulletEnemyPrefab2, transform.position, transform.rotation);
        }
        else if (vida < 84 && vida > 0)
        {
            Instantiate(BulletEnemyPrefab3, transform.position, transform.rotation);
        }
        Invoke("CreateBullet", 2);

    }

}