using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestService : SingltonBehaviour<ChestService>
{
    public ChestMasterScriptableObjects chestMasterScriptableObject;
    ChestController chestController;

    public ChestController SpawnChest(Transform spwaChest){
        chestController = new ChestController(chestMasterScriptableObject, spwaChest);
        return chestController;
    }
}
