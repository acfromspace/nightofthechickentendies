using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HungrySkullController : MonoBehaviour
{

	public GameObject associatedPlatform;

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "tendie")
		{
			//close mouth
			associatedPlatform.GetComponent<MovingPlatformController>().enableMove();
			Debug.Log("Skull is happy");
		}
		Destroy(other.gameObject);
	}
}
