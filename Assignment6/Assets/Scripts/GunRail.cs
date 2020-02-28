using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Sam Ferstein
 * GunRail.cs
 * Assignment 6
 * This is one of the concrete products that implement the main product class.
 */

public class GunRail : Weapon
{
    public GunRail()
    {
        this.weaponType = "Railgun";
        this.weapon = WeaponType.GUN;
        this.bulletSpeed = 7;
        this.Damage = 2;
    }
}
