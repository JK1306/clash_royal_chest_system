using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerProfile : SingltonBehaviour<PlayerProfile>
{
    int coins;
    int gems;
    string playerName;
    public GameObject notificationPanel;
    public Text notificationPanelText;
    public Button notificationPanelButton;
    [Tooltip("Chest Spawn Button")]
    public Button spawnButton;
    public ChestSlotManager chestSlotManager;
    public Text coinDisplayText,
                gemDisplayText;
    Queue<ChestSlot> openingQueue;
    public override void Awake() {
        base.Awake();
        spawnButton.onClick.AddListener(SpawnChest);
        coins = 0;
        gems = 0;
        UpdateScoreBoard();

        notificationPanelButton.onClick.AddListener(DisableNoitificationPanel);
    }

    void DisableNoitificationPanel(){
        notificationPanel.SetActive(false);
    }

    void SpawnChest(){
        chestSlotManager.AllocateChest();
    }

    public void DeallocateChest(){
        chestSlotManager.DeallocateChest();
    }

    private void OnDisable() {
        spawnButton.onClick.RemoveListener(SpawnChest);
        notificationPanelButton.onClick.RemoveListener(DisableNoitificationPanel);
    }

    public bool RedeemGem(int gemCount){
        if(gems >= gemCount){
            gems -=  gemCount;
            UpdateScoreBoard();
            return true;
        }
        AlertMessage("Player "+playerName+" does have enough Gem");
        return false;
    }

    void AlertMessage(string alertMsg){
        notificationPanel.SetActive(true);
        notificationPanelText.text = alertMsg;
    }

    public void AddCoin(int coinCount){
        coins += coinCount;
        UpdateScoreBoard();
    }

    public void AddGem(int gemCount){
        gems += gemCount;
        UpdateScoreBoard();
    }

    void UpdateScoreBoard(){
        coinDisplayText.text = "Coin : "+coins;
        gemDisplayText.text = "Gem : "+gems;
    }
}
