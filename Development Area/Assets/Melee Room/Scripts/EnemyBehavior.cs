using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour {

    Transform player;
    float RotSpeed = 3.0f, MoveSpeed = 1.0f;
    public int health = 100;

    void Start()
    {
        player = GameObject.FindWithTag ("Player").transform;
    }

    void Update()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(player.position - transform.position), RotSpeed * Time.deltaTime);
        transform.position += transform.forward * MoveSpeed * Time.deltaTime;
    }

	public void TakeDamage(int Amount)
    {
        health -= Amount;
        if (health <= 0)
        {
            Destroy();
        }
    }

    void Destroy()
    {
        Destroy(this.gameObject);
    }

    void OnCollisonEnter(Collider other)
    {
        Destroy(this.gameObject);
    }
}