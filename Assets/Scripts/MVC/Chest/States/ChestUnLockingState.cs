using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class ChestUnLockingState : State
{
    float waitTime;
    TimeSpan waitTimer;
    string returnString;
    public ChestUnLockingState(ChestModel chestModel) : base(chestModel){}

    public override void OnEnter()
    {
        if(base.chestModel == null){
            Debug.Log("Chest Model is Not Set");
        }
        waitTime = base.chestModel.chest.GetOpenTimer();
        waitTimer = TimeSpan.FromMinutes(waitTime);

        this.chestState = ChestStates.UnLocking;
    }
    public override void OnAccept()
    {
        this.chestState = ChestStates.UnLocked_not_collected;
    }
    public override void OnDecline()
    {
        this.chestState = ChestStates.UnLocking;
    }
    public override string DisplayText()
    {
        return "Would you like to UnLock Chest With the given Gem Value";
    }
    public override string ChestDisplayText()
    {
        return returnString;
    }

    async void ChestOpenTimeCountDown(){
        // if(waitTimer < TimeSpan.Zero) { return; }
        returnString = string.Format("{0:00} {1:00}", waitTimer.TotalMinutes, waitTimer.TotalSeconds);
        await Task.Delay(TimeSpan.FromSeconds(1));
        waitTimer.Subtract(TimeSpan.FromSeconds(1));
    }
}
