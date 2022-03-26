using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestModel
{
    public Chest chest { get; private set; }
    public Color applyColor { get; private set; }
    public ChestModel(ChestTypeScriptableObject chestSo){
        this.chest = chestSo.chest;
        this.applyColor = applyColor;
    }
}
