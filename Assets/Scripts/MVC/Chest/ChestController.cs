using UnityEngine;
public class ChestController
{
    ChestModel chestModel;
    ChestView chestView;
    StateManager stateManager;
    public ChestController(ChestMasterScriptableObjects chestMaster, Transform spawnLocation){
        chestModel = new ChestModel(chestMaster.chestTypes.selectRandom<ChestTypeScriptableObject>());
        SpawnChest(chestMaster.chestView, spawnLocation);
        this.chestView.setUpModel(chestModel);
        this.stateManager = this.chestView.GetStateManager();
    }

    void SpawnChest(ChestView chestView, Transform spawnSlot){
        this.chestView = GameObject.Instantiate<ChestView>(chestView, spawnSlot.position, spawnSlot.rotation);
        this.chestView.transform.SetParent(spawnSlot);
    }

    // void 

}
