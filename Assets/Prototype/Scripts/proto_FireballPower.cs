using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proto_FireballPower : MonoBehaviour
{

	public GameObject _fireball;

	public float _fireballSpeed;

	public Transform _spawnPoint;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Left Click
		if (Input.GetMouseButtonDown(0))
		{
			Fire();
		}
	}

	void Fire()
	{
		var fireballInstance = (GameObject) Instantiate(_fireball, _spawnPoint.position, _spawnPoint.rotation);
		fireballInstance.GetComponent<Rigidbody>().velocity = (_spawnPoint.transform.forward * this._fireballSpeed); 
	}
}
