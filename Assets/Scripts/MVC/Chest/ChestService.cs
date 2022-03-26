using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChestService : SingltonBehaviour<ChestService>
{
    public ChestMasterScriptableObjects chestMasterScriptableObject;
    [Tooltip("Chest Panel")]
    public ChestPanelManager chestPanelManager;
    public ChestController SpawnChest(Transform spwaChest){
        ChestController chestController = new ChestController(chestMasterScriptableObject, spwaChest, chestPanelManager);
        return chestController;
    }

    // public void DisplayPanel(string panelDisplayMsg){
    //     chestPanelManager.EnableObject();
    //     chestPanelManager.DisplayMessage(panelDisplayMsg);
    // }
}
