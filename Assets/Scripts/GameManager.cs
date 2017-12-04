using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager Instance = null;

    /// <summary>
    /// Initializes the GameManager Instance
    /// </summary>
    private void Awake()
    {
        //Initialize the singelton pattern.
        if (Instance != null) {
            Instance = this;
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
