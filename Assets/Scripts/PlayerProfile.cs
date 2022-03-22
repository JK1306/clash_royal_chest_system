using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerProfile : SingltonBehaviour<PlayerProfile>
{
    int coins;
    int gems;
    string playerName;
    public Button spawnButton;
    public ChestSlotManager chestSlotManager;
    Queue<ChestSlot> openingQueue;
    private void Awake() {
        spawnButton.onClick.AddListener(SpawnChest);
    }

    void SpawnChest(){
        ChestSlot availableSlot = chestSlotManager.GetSlot();
        if(availableSlot != null){
            ChestController chestController =  ChestService.instance.SpawnChest(availableSlot.gameObject.transform);
            chestSlotManager.AllocateChest(availableSlot, chestController);
        }else{
            Debug.Log("All Slots are Allocated");
        }
    }

    private void OnDisable() {
        spawnButton.onClick.RemoveListener(SpawnChest);
    }
}
