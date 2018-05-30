using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour {

	void Start () {
        iTween.ShakePosition(gameObject, iTween.Hash("x", 0.1, "looptype", "pingpong"));
    }
}
