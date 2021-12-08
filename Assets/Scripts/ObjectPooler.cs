using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyPrefab;
    [SerializeField]
    private Queue<GameObject> enemyPool = new Queue<GameObject>();
    [SerializeField]
    private int poolStartSize = 5;
    // Start is called before the first frame update
    private void Start()
    {
        for(int i=0;i<poolStartSize;i++)
        {
            GameObject enemy = Instantiate(enemyPrefab);
            enemyPool.Enqueue(enemy);
            enemy.SetActive(false);
        }
    }
    public GameObject getEnemy()
    {
        if(enemyPool.Count>0)
        {
            GameObject enemy = enemyPool.Dequeue();
            enemy.SetActive(true);
            return enemy;
        }
        else
        {
            GameObject enemy = Instantiate(enemyPrefab);
            return enemy;
        }
    }
    public void ReturnEnemy(GameObject enemy)
    {
        enemyPool.Enqueue(enemy);
        enemy.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
