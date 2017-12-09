using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour {

    public int health = 100;

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
}