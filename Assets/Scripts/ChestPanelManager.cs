using System;
using UnityEngine;
using UnityEngine.UI;

public class ChestPanelManager : MonoBehaviour
{
    [SerializeField]
    private Text statementDisplay;
    public Button yesBtn,
                    noBtn;
    public static event Action yesBtnClicked;
    public static event Action noBtnClicked;

    private void OnEnable(){
        yesBtn.onClick.AddListener(Accepted);
        noBtn.onClick.AddListener(Rejected);
    }

    void Accepted(){
        yesBtnClicked?.Invoke();
        DisableObject();
    }

    void Rejected(){
        noBtnClicked?.Invoke();
        DisableObject();
    }

    private void OnDisable() {
        yesBtn.onClick.RemoveListener(Accepted);
        noBtn.onClick.RemoveListener(Rejected);
    }

    public void DisplayMessage(string displayValue){
        statementDisplay.text = displayValue;
    }

    public void EnableObject(){
        gameObject.SetActive(true);
    }

    public void DisableObject(){
        gameObject.SetActive(false);
    }
}
