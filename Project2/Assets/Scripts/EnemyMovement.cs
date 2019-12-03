using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    //speed and list of waypoints
    public float speed = 10f;
    private Transform target;
    private int waypointIndex = 0;

    //get the first target of the waypoints list
    void Start()
    {
        target = Waypoints.points[0];
    }

    //move towards the target waypoint
    void Update()
    {
        Vector3 direction = target.position - transform.position;
        transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);

        //once you reach the waypoint, get the next waypoint
        if (Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            getNextWaypoint();
        }
    }

    //get the next waypoint in the list
    void getNextWaypoint()
    {
        if(waypointIndex >= Waypoints.points.Length - 1)
        {
            EndPath();
        }
        waypointIndex += 1;
        target = Waypoints.points[waypointIndex];
    }
    void EndPath()
    {
        GaveOver.lives--;
        Destroy(gameObject);
    }
}
