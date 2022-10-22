using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    
    public GameObject spawnPoint;

    public GameObject[] navigateWaypoints;

    [SerializeField]
    private GameObject[] enemies;

    // Start is called before the first frame update
    void Start()
    {
        spawnPoint = GameObject.FindGameObjectWithTag("SpawnPoint");
        Instantiate(enemies[0], spawnPoint.transform.position, Quaternion.identity);
    }   

    // Update is called once per frame
    void Update()
    {
        
    }
}
