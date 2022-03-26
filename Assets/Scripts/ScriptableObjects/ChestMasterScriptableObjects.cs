using UnityEngine;

[CreateAssetMenu(fileName = "ChestMasterScriptableObjects", menuName = "ScriptableObjects/ChestMasterScriptableObjects", order = 0)]
public class ChestMasterScriptableObjects : ScriptableObject {
    public ChestView chestView;
    public ChestTypeScriptableObject[] chestTypes;
}