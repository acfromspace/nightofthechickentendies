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

    private float min, max;


	// Update is called once per frame
	public void enableMove()
	{
		canMove = true;
        min = transform.position.z - 30;
        max = transform.position.z + 30;
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
            //transform.position += distanceAmp * dir * Mathf.Sin(6 * speed * Time.deltaTime);
            //transform.position += dir * Mathf.PingPong(Time.deltaTime, 6);
            transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.PingPong(Time.deltaTime * speed, max - min) + min);

            yield return new WaitForSeconds(0.01f);
        }
	}
}

	
