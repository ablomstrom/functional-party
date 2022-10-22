using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{


    private GameObject levelManager;
    private GameObject[] navigateWaypoints;
    private Transform nextWaypoint;

    private float moveSpeed = 0.05f;
    private float nextWaypointDistane = 1f;
    private int currentWaypointIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        levelManager = GameObject.FindGameObjectWithTag("LM");
        navigateWaypoints = levelManager.GetComponent<LevelController>().navigateWaypoints;
        nextWaypoint = navigateWaypoints[currentWaypointIndex].transform;
        this.transform.position = levelManager.GetComponent<LevelController>().spawnPoint.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        MoveEnemy();
    }


    void MoveEnemy()
    {
        if (Vector3.Distance(this.transform.position, nextWaypoint.position) < nextWaypointDistane)
        {
            currentWaypointIndex++;
            nextWaypoint = navigateWaypoints[currentWaypointIndex].transform;
        }
        transform.position = Vector3.MoveTowards(transform.position, nextWaypoint.position, moveSpeed);
    }
}
