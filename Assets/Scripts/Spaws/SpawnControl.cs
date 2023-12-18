using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnControl : MonoBehaviour
{
    public GameObject PrefabEnemy;
    public Transform spawn;
    void Start()
    {
        Invoke("CreateEnemy", 3);
    }
    void CreateEnemy()
    {
        Vector2 spawnPosition = new Vector2(-7.88f, -23.14f);

        Instantiate(PrefabEnemy, spawnPosition, transform.rotation);
        Invoke("CreateEnemy", 3);
    }
    
}
