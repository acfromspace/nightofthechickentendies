using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proto_FireballPower : MonoBehaviour
{

	public GameObject fireballPrefab;

	public float fireballForce;

	public Transform spawnPoint;
	
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
		//Ray
		Debug.DrawRay(transform.position, transform.forward, Color.green);
		
		if (Input.GetMouseButtonDown(0))
		{
			Fire();
		}
	}

	void Fire()
	{
		var fireballInstance = (GameObject) Instantiate(fireballPrefab, spawnPoint.transform.position, Quaternion.identity);
		fireballInstance.GetComponent<Rigidbody>().AddForce(transform.forward * fireballForce);  
		Object.Destroy(fireballInstance, 10.0f);
	}
}
