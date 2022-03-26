using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestSlotManager : MonoBehaviour
{
    public ChestSlot slot1, slot2, slot3, slot4;
    ChestSlot[] chestSlots;
    private void Awake() {
       chestSlots = new ChestSlot[] {slot1, slot2, slot3, slot4};
    }

    public ChestSlot GetFreeSlot(){
        for(int i=0; i<chestSlots.Length; i++){
            if(chestSlots[i].occupied == false) return chestSlots[i];
        }
        return null;
    }

    ChestSlot GetSlot(ChestSlot chestSlot){
        for(int i=0; i<chestSlots.Length; i++){
            if(chestSlot.Equals(chestSlots[i])){
                return chestSlots[i];
            }
        }
        return null;
    }

    public void AllocateChest(){
        ChestSlot availableSlot = GetFreeSlot();
        if(availableSlot != null){
            ChestController chestController =  ChestService.instance.SpawnChest(availableSlot.gameObject.transform);
            availableSlot.chest = chestController;
            availableSlot.occupied = true;
        }else{
            Debug.Log("All Slots are Allocated");
        }
    }

    internal void DeallocateChest()
    {
        foreach(ChestSlot slot in chestSlots){
            if(slot.chest != null && slot.chest.stateManager.currentState.chestState == ChestStates.None){
                slot.chest = null;
                slot.occupied = false;
            }
        }
    }
}
