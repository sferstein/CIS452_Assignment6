using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Sam Ferstein
 * SwordHeavy.cs
 * Assignment 6
 * This is one of the concrete products that implement the main product class.
 */

public class SwordHeavy : Weapon
{
    public SwordHeavy()
    {
        this.weaponType = "Heavy";
        this.weapon = WeaponType.SWORD;
        this.Damage = 2;
    }
}
