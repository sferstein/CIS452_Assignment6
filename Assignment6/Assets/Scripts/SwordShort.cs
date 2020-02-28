using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Sam Ferstein
 * SwordShort.cs
 * Assignment 6
 * This is one of the concrete products that implement the main product class.
 */

public class SwordShort : Weapon
{
    public SwordShort()
    {
        this.weaponType = "Short";
        this.weapon = WeaponType.SWORD;
        this.Damage = 1;
    }
}
