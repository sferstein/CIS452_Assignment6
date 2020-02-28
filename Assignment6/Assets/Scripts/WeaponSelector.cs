using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Sam Ferstein
 * WeaponSelector.cs
 * Assignment 6
 * This is the slector class that controls switching the weapons for the factory method.
 */

public class WeaponSelector : MonoBehaviour
{
    public WeaponCreator weaponCreator;
    public bool weaponCreatorIsGun;
    public bool canShoot;
    public string bulletType;

    public GameObject shortSword;
    public GameObject heavySword;
    public GameObject gunBarrel;

    // Start is called before the first frame update
    void Start()
    {
        weaponCreator = new GunCreator();
        weaponCreatorIsGun = true;
        canShoot = true;
    }

    public GameObject switchWeapon(string type)
    {
        string weapon = null;

        weapon = weaponCreator.ChooseWeaponType(type);

        GameObject weaponInstance = gameObject;

        return weaponInstance;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            Debug.Log("Tab key pressed");

            if (weaponCreatorIsGun)
            {
                weaponCreator = new SwordCreator();
                weaponCreatorIsGun = false;
                canShoot = false;
                gunBarrel.gameObject.SetActive(false);
                shortSword.gameObject.SetActive(true);
            }
            else
            {
                gunBarrel.gameObject.SetActive(true);
                weaponCreator = new GunCreator();
                canShoot = true;
                weaponCreatorIsGun = true;
                heavySword.gameObject.SetActive(false);
                shortSword.gameObject.SetActive(false);
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (weaponCreatorIsGun)
            {
                Debug.Log("Pistol Selected");
                bulletType = weaponCreator.ChooseWeaponType("Pistol");
            }
            else
            {
                heavySword.gameObject.SetActive(false);
                shortSword.gameObject.SetActive(true);
                Debug.Log("Short sword Selected");
            }

        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (weaponCreatorIsGun)
            {
                Debug.Log("Railgun Selected");
                bulletType = weaponCreator.ChooseWeaponType("Railgun");
            }
            else
            {
                heavySword.gameObject.SetActive(true);
                shortSword.gameObject.SetActive(false);
                Debug.Log("Heavy Sword Selected");
            }
        }
    }
}
