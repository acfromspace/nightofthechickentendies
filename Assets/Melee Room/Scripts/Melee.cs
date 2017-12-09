using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melee : MonoBehaviour {

    public Camera FPS;
    public float range;
    public LayerMask mask;
    public int damage;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1"))
        {
            Attack();
        }
	}

    void Attack()
    {
        RaycastHit hit;
        if (Physics.Raycast(FPS.transform.position, FPS.transform.forward, out hit, range, mask))
        {
            EnemyBehavior enemy = hit.transform.GetComponent<EnemyBehavior>();
            if (enemy != null)
            {
                enemy.TakeDamage(damage);
            }
        }
    }
}