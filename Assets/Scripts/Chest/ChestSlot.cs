using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class ChestSlot : MonoBehaviour
{
    public ChestController chest;
    public bool occupied=false;
    Button slotButton;
    private void Awake() {
        slotButton = GetComponent<Button>();
        slotButton.onClick.AddListener(ActivateChest);
    }

    void ActivateChest(){
        this.chest.ManagePanel();
    }
}
