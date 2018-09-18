using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(0.0f, 0.0f, 10.0f * Time.deltaTime));
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player") {
            //TODO Award player with some more ammo;
            Destroy(collision.gameObject);
        }
    }
}
