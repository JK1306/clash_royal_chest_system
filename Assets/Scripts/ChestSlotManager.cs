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

    public void AllocateChest(){
        ChestSlot availableSlot = GetSlot();
        if(availableSlot != null){
            ChestController chestController =  ChestService.instance.SpawnChest(availableSlot.gameObject.transform);
            // chestSlotManager.AllocateChest(availableSlot, chestController);
            availableSlot.chest = chestController;
            availableSlot.occupied = true;
        }else{
            Debug.Log("All Slots are Allocated");
        }
    }
}
