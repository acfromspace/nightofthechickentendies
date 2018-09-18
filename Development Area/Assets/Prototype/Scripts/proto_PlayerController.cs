using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proto_PlayerController : MonoBehaviour
{

	public float _playerSpeed;

	private Rigidbody _playerRigidBody;
	
	void Start ()
	{
		_playerRigidBody = GetComponent<Rigidbody>();
		
	}
	
	void FixedUpdate ()
	{
		float horizontalInput = Input.GetAxis("Horizontal");
		float verticalInput = Input.GetAxis("Vertical");
		
		Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput);
		_playerRigidBody.velocity = movement * _playerSpeed;
	}
}
