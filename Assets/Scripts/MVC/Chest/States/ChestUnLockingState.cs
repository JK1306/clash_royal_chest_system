using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

[Serializable]
public class ChestUnLockingState : State
{
    float waitTime;
    int seconds;
    string returnString;
    [SerializeField]
    bool runTimer;
    int gemCount;
    public ChestUnLockingState(ChestModel chestModel) : base(chestModel){
        returnString = waitTime.ToString();
    }

    public override void OnEnter()
    {
        waitTime = base.chestModel.chest.GetOpenTimer();
        // Debug.Log("Waiting Time from Models : "+waitTime);

        this.chestState = ChestStates.UnLocking;

        runTimer = true;
        seconds = 60;
        ChestOpenTimeCountDown();
    }

    public override void OnExit()
    {
        runTimer = false;
    }
    public override void OnAccept()
    {
        if(PlayerProfile.instance == null){
            Debug.Log("Player profile instance is null");
        }
        bool isReedemed = PlayerProfile.instance.RedeemGem(gemCount);
        Debug.Log("Is Redeemed : "+isReedemed);
        if(isReedemed){
            ChangeState();
        }
    }
    public override void OnDecline()
    {
        this.chestState = ChestStates.UnLocking;
    }
    public override string DisplayText()
    {
        return "Would you like to UnLock Chest With "+GetGemsCountToUnlock()+" Gem Value";
    }
    public override string ChestDisplayText()
    {
        return returnString;
    }

    async void ChestOpenTimeCountDown(){
        while(waitTime > 0 && runTimer) {
            returnString = waitTime.ToString()+" : "+seconds.ToString();
            await Task.Delay(TimeSpan.FromSeconds(1));
            seconds--;
            if(seconds <= 0){
                seconds = 60;
                waitTime--;
            }
        }
        ChangeState();
    }

    void ChangeState(){
        this.chestState = ChestStates.UnLocked_not_collected;
    }

    int GetGemsCountToUnlock(){
        float waitTimeToGem = waitTime/10;
        gemCount = (int)waitTimeToGem;
        if((waitTimeToGem - gemCount) > 0){
            gemCount++;
        }
        return gemCount;
    }
}
