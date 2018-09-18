using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsController : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
		StartCoroutine(Credits());
	}

	IEnumerator Credits()
	{
		yield return new WaitForSeconds(10);
		Application.Quit();
	}
}
