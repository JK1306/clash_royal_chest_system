using UnityEngine;
[System.Serializable]
public class State
{
    public ChestStates chestState;
    public virtual void OnTick(GameObject panel){}
}
