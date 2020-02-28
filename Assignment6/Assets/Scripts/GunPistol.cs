using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Sam Ferstein
 * GunPistol.cs
 * Assignment 6
 * This is one of the concrete products that implement the main product class.
 */

public class GunPistol : Weapon
{
    public GunPistol()
    {
        this.weaponType = "Pistol";
        this.weapon = WeaponType.GUN;
        this.bulletSpeed = 10;
        this.Damage = 1;
    }
}
