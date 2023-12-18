using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnControl2 : MonoBehaviour
{
    public GameObject PrefabEnemy2;
    public Transform spawn2;
    void Start()
    {
        Invoke("CreateEnemy2", 3);
    }
    void CreateEnemy2()
    {
        Vector2 spawnPosition = new Vector2(28.99f, -23.55f);

        Instantiate(PrefabEnemy2, spawnPosition, transform.rotation);
        Invoke("CreateEnemy2", 3);
    }
}
