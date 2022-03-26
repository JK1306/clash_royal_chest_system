using System;
using UnityEngine;
using UnityEngine.UI;

public class ChestPanelManager : MonoBehaviour
{
    ChestController chestController;
    [SerializeField]
    private Text statementDisplay;
    public Button yesBtn,
                    noBtn;
    public static event Action<ChestController> yesBtnClicked;
    public static event Action<ChestController> noBtnClicked;

    private void OnEnable(){
        yesBtn.onClick.AddListener(Accepted);
        noBtn.onClick.AddListener(Rejected);
    }

    void Accepted(){
        yesBtnClicked?.Invoke(chestController);
        DisableObject();
    }

    void Rejected(){
        noBtnClicked?.Invoke(chestController);
        DisableObject();
    }

    private void OnDisable() {
        yesBtn.onClick.RemoveListener(Accepted);
        noBtn.onClick.RemoveListener(Rejected);
    }

    public void DisplayMessage(string displayValue){
        statementDisplay.text = displayValue;
    }

    public void EnableObject(ChestController chestController){
        this.chestController = chestController;
        gameObject.SetActive(true);
    }

    public void DisableObject(){
        gameObject.SetActive(false);
    }
}
