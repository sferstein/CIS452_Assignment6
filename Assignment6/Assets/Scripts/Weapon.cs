using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Sam Ferstein
 * Weapon.cs
 * Assignment 6
 * This is the weapon product class for the factory method.
 */

[System.Serializable]
public class Weapon : MonoBehaviour
{
    public string weaponType;
    public enum WeaponType { GUN, NEUTRAL, SWORD }
    public WeaponType weapon;
    public int Damage;
    public float bulletSpeed;
}
