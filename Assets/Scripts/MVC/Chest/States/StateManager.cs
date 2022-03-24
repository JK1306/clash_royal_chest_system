using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StateManager : MonoBehaviour
{
    ChestView chestView;
    ChestModel chestModel;
    ChestStates prevState;
    public Text timerDisplay;
    [SerializeField]
    State currentState;
    ChestLockedState lockedState;
    ChestUnLockingState unLockingState;
    ChestUnLockedNotCollected unLockedNotCollectedState;
    ChestCollected colledted;
    private void Start(){
        chestView = GetComponent<ChestView>();
        chestModel = chestView.GetChestModel();

        lockedState = new ChestLockedState(chestModel);
        unLockingState = new ChestUnLockingState(chestModel);
        unLockedNotCollectedState = new ChestUnLockedNotCollected(chestModel);
        colledted = new ChestCollected(chestModel);

        currentState = lockedState;
        currentState.OnEnter();
        prevState = lockedState.chestState;

        // timerDisplay = GetComponent<Text>();
    }

    private void OnEnable() {
        ChestPanelManager.yesBtnClicked += YesButtonClicked;
        ChestPanelManager.noBtnClicked += NoButtonClicked;
    }

    private void OnDisable() {
        currentState.OnExit();
        ChestPanelManager.yesBtnClicked -= YesButtonClicked;
        ChestPanelManager.noBtnClicked -= NoButtonClicked;
    }

    void YesButtonClicked(){
        // Debug.Log("yes Button CLicked");
        currentState.OnAccept();
    }

    void NoButtonClicked(){
        // Debug.Log("No Button CLicked");
        currentState.OnDecline();
    }

    public string GetDisplayStatement(){
        return currentState.DisplayText();
    }

    private void Update() {
        timerDisplay.text = currentState.ChestDisplayText();
        if(prevState != currentState.chestState){
            ChangeState(currentState.chestState);
        }
    }

    void ChangeState(ChestStates nextState){
        currentState.OnExit();
        switch(nextState){
            case ChestStates.Locked:
                currentState = lockedState;
                break;
            case ChestStates.UnLocking:
                currentState = unLockingState;
                break;
            case ChestStates.UnLocked_not_collected:
                currentState = unLockedNotCollectedState;
                break;
            case ChestStates.Collected:
                currentState = colledted;
                break;
        }
        currentState.OnEnter();
        prevState = currentState.chestState;
    }
}
