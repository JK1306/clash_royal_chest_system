using UnityEngine;
[System.Serializable]
public class State
{
    public ChestStates chestState;
    protected ChestModel chestModel;
    public State(ChestModel chestModel)
    {
        this.chestModel = chestModel;
    }
    public virtual void OnAccept(){}
    public virtual void OnDecline(){}
    public virtual void OnEnter(){}
    public virtual void OnExit(){}
    public virtual void OnTick(GameObject panel){}
    public virtual string DisplayText(){ return ""; }
    public virtual string ChestDisplayText(){ return ""; }
}
