﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChestView : MonoBehaviour
{
    public Text timerDisplay;
    ChestModel chestModel;

    public void setUpModel(ChestModel chestModel){
        this.chestModel = chestModel;
        applyColor();
    }

    void applyColor(){
        if(gameObject.TryGetComponent(out Image image)){
            image.color = chestModel.applyColor;
        }
    }
}
