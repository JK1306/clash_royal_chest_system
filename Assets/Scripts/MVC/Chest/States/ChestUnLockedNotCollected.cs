using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ChestUnLockedNotCollected : State
{
    public ChestUnLockedNotCollected(ChestModel chestModel) : base(chestModel){}

    public override void OnEnter()
    {
        this.chestState = ChestStates.UnLocked_not_collected;
    }

    public override void OnAccept()
    {
        ChangeState();
    }

    public override string DisplayText()
    {
        return "Would you like to collect Chest Reward";
    }

    public override string ChestDisplayText()
    {
        return "Collect Reward";
    }

    void ChangeState(){
        this.chestState = ChestStates.Collected;
    }
}
