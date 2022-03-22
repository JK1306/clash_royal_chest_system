using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestSlotManager : MonoBehaviour
{
    public ChestSlot slot1, slot2, slot3, slot4;
    ChestSlot[] chestSlots;
    // int slotCount=4;
    private void Awake() {
       chestSlots = new ChestSlot[] {slot1, slot2, slot3, slot4};
    }

    public ChestSlot GetSlot(){
        for(int i=0; i<chestSlots.Length; i++){
            if(chestSlots[i].occupied == false) return chestSlots[i];
        }
        return null;
    }

    public void AllocateChest(ChestSlot chestSlot, ChestController chest){
        chestSlot.chest = chest;
        chestSlot.occupied = true;
        // spawnChest.gameObject.transform.position = chestSlot.gameObject.post
        // ChestSlot chestSlot = GetSlot();
        // if(chestSlot != null){
        //     chestSlot.chest = spawnChest;
        //     chestSlot.occupied = true;
        // }
    }
}
