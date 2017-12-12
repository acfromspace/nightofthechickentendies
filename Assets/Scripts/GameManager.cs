using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager Instance = null;

    public GameObject Gun_HUD;
    public GameObject Melee_HUD;
    public GameObject Grenade_HUD;

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
    void Start () {
        CurrentPlayerWeapon = PlayerWeaponType.NONE;
        meleeUnlocked = true;
        gunUnlocked = true;
        grenadeUnlocked = true;
        Score = 0;
	}
	
	// Update is called once per frame
	void Update () {
        Gun_HUD.SetActive(CurrentPlayerWeapon == PlayerWeaponType.GUN);
        Melee_HUD.SetActive(CurrentPlayerWeapon == PlayerWeaponType.MELEE);
        Grenade_HUD.SetActive(CurrentPlayerWeapon == PlayerWeaponType.GRENADE);

        if (Input.GetKey(KeyCode.Alpha1) && meleeUnlocked)
        {
            CurrentPlayerWeapon = PlayerWeaponType.MELEE;
        }
        else if (Input.GetKey(KeyCode.Alpha2))
        {
            CurrentPlayerWeapon = PlayerWeaponType.GUN;
        }
        else if(Input.GetKey(KeyCode.Alpha3)){
            CurrentPlayerWeapon = PlayerWeaponType.GRENADE;
        }
	}
}
