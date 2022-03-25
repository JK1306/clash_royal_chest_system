using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ChestCollected : State
{
    public ChestCollected(ChestModel chestModel) : base(chestModel){}
    public override void OnEnter()
    {
        PlayerProfile.instance.AddCoin(this.chestModel.chest.reward.getCoin());
        PlayerProfile.instance.AddGem(this.chestModel.chest.reward.getGem());
        this.chestState = ChestStates.Collected;
    }    
}
