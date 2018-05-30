using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour {

    public Transform player;
    //public Vector3 looker;

    void Start () {

	}

    void OnEnable()
    {
        //iTween.RotateTo(gameObject, iTween.Hash("x", -90.0f));
    }

    void Update () {
        //looker = new Vector3(-90.0f, 0.0f, 0.0f);
        iTween.LookTo(gameObject, iTween.Hash("looktarget", player, "easetype", "linear"));
        var oldRot = transform.localRotation;
        transform.localRotation = Quaternion.Euler(oldRot.x + -90, oldRot.y, oldRot.z);
        //gameObject.transform.position = new Vector3(-90.0f, 0.0f, 0.0f);
        // "axis", "y" for a quick fix in the hash parameters
    }
}
