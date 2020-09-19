using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{

    public Transform[] waypoints; //array of waypoints
    Vector3 targetPoint;

    public float speed = 1;

    public float distanceThreshold;

    void Start()
    {
        targetPoint = waypoints[0].position;
    }

    
    void Update()
    {
        if(Vector3.Distance(transform.position, targetPoint) < distanceThreshold)
        {
            changeTarget();
        }
        moveTowards();
    }

    void moveTowards()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPoint, Time.deltaTime * speed);
    }

    void changeTarget()
    {
        int randomIndex = Random.Range(0, waypoints.Length);
        targetPoint = waypoints[randomIndex].position;
    }

}
