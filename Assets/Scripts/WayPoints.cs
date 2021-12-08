using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoints : MonoBehaviour
{
    public GameObject[] waypoints;
    int currentWayPoint = 0;
    // float rotSpeed;
    public float speed;
    float wayPointRadius = 1;

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(waypoints[currentWayPoint].transform.position,transform.position)<wayPointRadius)
        {
            currentWayPoint++;
            if(currentWayPoint>=waypoints.Length)
            {
                currentWayPoint = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWayPoint].transform.position, Time.deltaTime * speed);
    }
}
