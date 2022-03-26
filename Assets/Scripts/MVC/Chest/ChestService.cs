using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChestService : SingltonBehaviour<ChestService>
{
    public ChestMasterScriptableObjects chestMasterScriptableObject;
    ChestController chestController;
    [Tooltip("Chest Panel")]
    public ChestPanelManager chestPanelManager;

    public ChestController SpawnChest(Transform spwaChest){
        chestController = new ChestController(chestMasterScriptableObject, spwaChest);
        return chestController;
    }

    public void DisplayPanel(string panelDisplayMsg){
        chestPanelManager.EnableObject();
        chestPanelManager.DisplayMessage(panelDisplayMsg);
    }
}
