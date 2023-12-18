using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawEnemy2 : MonoBehaviour
{
    public GameObject EnemyPrefab;
    public GameObject EnemyPrefab2;
    public GameObject EnemyPrefab3;

    public MovimientoEnemy vidaboss;


    public void CreateEnemy2()
    {
        float vida = vidaboss.GetVida();

        if (vida <= 250 && vida > 168)
        {
            Instantiate(EnemyPrefab, transform.position, transform.rotation);
        }
        else if (vida < 168 && vida > 84)
        {
            Instantiate(EnemyPrefab2, transform.position, transform.rotation);
        }
        else if (vida < 84 && vida > 0)
        {
            Instantiate(EnemyPrefab3, transform.position, transform.rotation);
        }

    }

}
