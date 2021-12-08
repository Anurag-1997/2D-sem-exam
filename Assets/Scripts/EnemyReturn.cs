using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyReturn : MonoBehaviour
{
    private ObjectPooler objectPool;
    // Start is called before the first frame update
    void Start()
    {
        objectPool = FindObjectOfType<ObjectPooler>();
    }

    private void OnDisable()
    {
        if(objectPool!=null)
        {
            objectPool.ReturnEnemy(this.gameObject);
        }
    }
}

