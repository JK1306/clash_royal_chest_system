using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestUnLockedNotCollected : State
{
    public ChestUnLockedNotCollected(ChestModel chestModel) : base(chestModel){}

    public override string DisplayText()
    {
        return "Would you like to collect Chest Reward";
    }
}
