using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Sam Ferstein
 * SwordCreator.cs
 * Assignment 6
 * This is the conrete sword creator for the factory method.
 */

public class SwordCreator : WeaponCreator
{
    private string weaponType;

    public override string ChooseWeaponType(string type)
    {
        if (type.Equals("Short"))
        {
            weaponType = "Short";
        }
        else if (type.Equals("Heavy"))
        {
            weaponType = "Heavy";
        }

        return weaponType;
    }
}
