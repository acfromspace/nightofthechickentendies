using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proto_CameraController : MonoBehaviour
{
	public GameObject _player;

	public Vector3 _cameraOffset;

	public Vector3 _cameraRotation;
	
	// Use this for initialization
	void Start ()
	{
		transform.rotation = Quaternion.Euler(_cameraRotation);
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.position = _player.transform.position + _cameraOffset;
	}
}
