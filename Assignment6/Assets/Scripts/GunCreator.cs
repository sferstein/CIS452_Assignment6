using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Sam Ferstein
 * GunCreator.cs
 * Assignment 6
 * This is the concrete gun creator for the factory method.
 */

public class GunCreator : WeaponCreator
{
    private string bulletPrefab;

    public override string ChooseWeaponType(string type)
    {
        if (type.Equals("Pistol"))
        {
            bulletPrefab = "Pistol";
            Debug.Log("Pistol bullet");
        }
        else if (type.Equals("Railgun"))
        {
            bulletPrefab = "Railgun";
            Debug.Log("Railgun bullet");
        }

        return bulletPrefab;
    }
}
