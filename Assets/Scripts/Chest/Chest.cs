[System.Serializable]
public class Chest
{
    [UnityEngine.SerializeField]
    ChestType chestType;
    [UnityEngine.SerializeField]
    float openTimer;
    public Reward reward;
    public float GetOpenTimer() => openTimer;
}
