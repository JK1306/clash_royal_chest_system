using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ChestLockedState : State
{
    public ChestLockedState(ChestModel chestModel) : base(chestModel){}

    public override void OnEnter()
    {
        this.chestState = ChestStates.Locked;
    }
    public override void OnAccept()
    {
        this.chestState = ChestStates.UnLocking;
    }
    public override void OnDecline()
    {
        this.chestState = ChestStates.Locked;
    }
    public override string DisplayText() => "Would you like to Open this Chest";

    public override string ChestDisplayText()
    {
        return "Chest Locked";
    }
}
