using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChestService : SingltonBehaviour<ChestService>
{
    public ChestMasterScriptableObjects chestMasterScriptableObject;
    [Tooltip("Panel to Manage Chest Clicks")]
    public GameObject panel;
    [Tooltip("Text to Display Message")]
    public Text panelMsgDisplay;
    ChestController chestController;

    public ChestController SpawnChest(Transform spwaChest){
        chestController = new ChestController(chestMasterScriptableObject, spwaChest);
        return chestController;
    }

    public void DisplayPanel(string panelDisplayMsg){
        panel.SetActive(true);
        panelMsgDisplay.text = panelDisplayMsg;
    }
}
