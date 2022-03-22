using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    [SerializeField]
    State currentState;
    State lockedState,
            unLockingState,
            unLockedNotCollectedState,
            colledted;
    private void Awake() {
        lockedState = new ChestLockedState();
        unLockingState = new ChestUnLockingState();
        unLockedNotCollectedState = new ChestUnLockedNotCollected();
        colledted = new ChestCollected();

        currentState = lockedState;
    }
}
