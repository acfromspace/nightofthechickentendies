using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public static GameManager Instance = null;
    
//    public GameObject Gun_HUD;
//    public GameObject Melee_HUD;
//    public GameObject Grenade_HUD;

    public enum PlayerWeaponType : byte {
        NONE,
        MELEE,
        GRENADE,
        GUN
    }

    public PlayerWeaponType CurrentPlayerWeapon;
    public uint Score;

    public bool meleeUnlocked { get; private set; }
    public bool gunUnlocked { get; private set; }
    public bool grenadeUnlocked { get; private set; }
    public bool pauseMenuToggle = false;
    
    public string firstSceneName;
    public GameObject PauseMenuCanvas;
    
    /// <summary>
    /// Initializes the GameManager Instance
    /// </summary>
    private void Awake()
    {
        //Initialize the singelton pattern.
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(transform.gameObject);
        }
    }

    // Use this for initialization
    void Start ()
    {
        PauseMenuCanvas.SetActive(pauseMenuToggle);
//        CurrentPlayerWeapon = PlayerWeaponType.NONE;
//        meleeUnlocked = true;
//        gunUnlocked = true;
//        grenadeUnlocked = true;
//        Score = 0;
    }
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyUp(KeyCode.Escape))
	    {
	        PauseGame();
	    }
	    if (pauseMenuToggle)
	    {
	        Debug.Log("Stop player from moving");
	    }
	}

    public void StartGame()
    {
        SceneManager.LoadScene(firstSceneName);
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }

    public void PauseGame()
    {
        pauseMenuToggle = !pauseMenuToggle;
        PauseMenuCanvas.SetActive(pauseMenuToggle);
    }
}
