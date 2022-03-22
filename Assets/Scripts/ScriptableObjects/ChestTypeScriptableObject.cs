using UnityEngine;

[CreateAssetMenu(fileName = "ChestTypeScriptableObject", menuName = "ScriptableObjects/ChestTypeScriptableObject", order = 0)]
public class ChestTypeScriptableObject : ScriptableObject {
    public Chest chest;
    public Color applyColor;
}