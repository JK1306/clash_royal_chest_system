using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChestView : MonoBehaviour
{
    ChestModel chestModel;
    ChestController chestController;
    public void setUpModel(ChestModel chestModel, ChestController chestController){
        this.chestModel = chestModel;
        this.chestController = chestController;
        applyColor();
    }

    void applyColor(){
        if(gameObject.TryGetComponent(out Image image)){
            image.color = chestModel.applyColor;
        }
    }

    public StateManager GetStateManager()
    {
        return GetComponent<StateManager>();
    }

    public ChestModel GetChestModel(){
        return chestModel;
    }

    public void DestroyChest(){
        chestController.DestroyChest();
    }

    private void OnDestroy() {
        Debug.Log("came to Ondestroy");
        chestController = null;
    }
}
