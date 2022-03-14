using UnityEngine;

[CreateAssetMenu(fileName = "ChestTypeScriptableObject", menuName = "ScriptableObjects/ChestTypeScriptableObject", order = 0)]
public class ChestTypeScriptableObject : ScriptableObject {
    public ChestType chestType;
    public Reward reward;
    public float timerMins;
}