using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProfile : MonoBehaviour
{
    int coins;
    int gems;
    string playerName;
    public ChestSlot slot1,
                slot2,
                slot3,
                slot4;

    Queue<ChestSlot> openingQueue;
}
