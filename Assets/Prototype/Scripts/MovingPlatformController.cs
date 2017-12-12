using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatformController : MonoBehaviour
{

	public Boolean canMove = false;

    public float zStart, zEnd;

	private GameObject target = null;

	private Vector3 offset;

	private Vector3 min, max;

	public float inverseSpeed;
	
	private void Start()
	{
		min = new Vector3(transform.position.x, transform.position.y, transform.position.z - zStart);
		max = new Vector3(transform.position.x, transform.position.y, transform.position.z + zEnd);
	}
	// Update is called once per frame
	public void enableMove()
	{
		canMove = true;
	}

	void Update()
	{
		if (canMove)
		{
			StartCoroutine(MovePlatform());
		}
	}

	IEnumerator MovePlatform()
	{
		yield return new WaitForSeconds(0.02f);
		while (canMove)
		{
			transform.position = Vector3.Lerp(min, max, Mathf.PingPong(Time.time * 1/inverseSpeed, 1));
            yield return new WaitForSeconds(0.02f);
        }
	}

	void OnTriggerStay(Collider other)
	{
		target = other.gameObject;
		offset = target.transform.position - transform.position;
	}

	void OnTriggerExit(Collider other)
	{
		target = null;
	}

	private void LateUpdate()
	{
		if (target != null)
		{
			target.transform.position = transform.position + offset;
		}
	}
}

	
