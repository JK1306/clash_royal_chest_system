using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ExtensionFunctions
{
    public static T selectRandom<T>(this T[] arr){
        return arr[Random.Range(0, arr.Length)];
    }

    // public static void AllocateChest(this ChestSlot chestSlot, Chest spawnChest){
    //     chestSlot.chest = spawnChest;
    //     chestSlot.occupied = true;
    //     // spawnChest.
    // }
}
