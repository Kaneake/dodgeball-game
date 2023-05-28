using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointMove : MonoBehaviour
{
    [SerializeField] GameObject[] waypoints;
    int currentWaypointIndex = 0;
    [SerializeField] float speed = 2f;
    void Update()
    {
        //if reaches first index, open game over screen
        if(Vector3.Distance(transform.position, waypoints[currentWaypointIndex].transform.position) < 0f)
        {
            currentWaypointIndex++;
            if(currentWaypointIndex >= waypoints.Length)
            {
                currentWaypointIndex = 0;
            }
        }
        //transform refers to whatever the WaypointMovement class is added to as component
        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, speed*Time.fixedDeltaTime);

    }
}
