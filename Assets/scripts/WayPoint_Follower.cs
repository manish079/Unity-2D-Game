using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoint_Follower : MonoBehaviour
{
    [SerializeField] private GameObject[] waypoints;
    private int CurrentWayPointIndex = 0;

    [SerializeField] private float speed = 2f;
    private void Update()
    {
        if(Vector2.Distance(waypoints[CurrentWayPointIndex].transform.position, transform.position) < .1f)
        {
            CurrentWayPointIndex++;
            if(CurrentWayPointIndex >= waypoints.Length)
            {
                CurrentWayPointIndex = 0;
            }
        }

        transform.position = Vector2.MoveTowards(transform.position, waypoints[CurrentWayPointIndex].transform.position, Time.deltaTime * speed);
    }
}
