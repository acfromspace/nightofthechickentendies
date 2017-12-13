using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject enemy;
    public float spawnTime = 3f;
    public Transform[] spawnPoints;
    public float fireSpeed;

    void Start()
    {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }


    void Spawn()
    {
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);

        var spawnenemy = (GameObject)Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
        enemy.GetComponent<Rigidbody>().velocity = transform.forward * fireSpeed;
    }
}