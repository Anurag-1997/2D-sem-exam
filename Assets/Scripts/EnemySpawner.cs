using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private float timeToSpawn = 5f;
    private float timeSinceSpawn;
    private ObjectPooler objectpool;
    private Vector2 spawnPosition;
    // Start is called before the first frame update
    void Start()
    {
        objectpool = FindObjectOfType<ObjectPooler>();
    }

    // Update is called once per frame
    void Update()
    {
        spawnPosition = new Vector2(Random.Range(-6, 6), Random.Range(-6, 6));
        timeSinceSpawn += Time.deltaTime;
        if(timeSinceSpawn>=timeToSpawn)
        {
            GameObject newEnemy = objectpool.getEnemy();
            newEnemy.transform.position = spawnPosition;
            timeSinceSpawn = 0f;
        }
    }
}
