using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatformController : MonoBehaviour
{

	public Boolean canMove = false;

	public float distanceAmp;

	public float speed;

	public Vector3 direction = Vector3.forward;


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
		yield return new WaitForSeconds(0.01f);
		while (canMove)
		{
			var dir = transform.TransformDirection(direction);
			transform.position += distanceAmp * dir * Mathf.Sin(6 * speed * Time.time);
		}
	}
}

	
