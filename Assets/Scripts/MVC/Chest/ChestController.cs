using UnityEngine;
public class ChestController
{
    ChestView chestView;
    ChestModel chestModel;
    public StateManager stateManager { get; private set;}
    ChestPanelManager chestPanelManager;
    public ChestController(ChestMasterScriptableObjects chestMaster, Transform spawnLocation, ChestPanelManager chestPanelManager){
        chestModel = new ChestModel(chestMaster.chestTypes.selectRandom<ChestTypeScriptableObject>());
        SpawnChest(chestMaster.chestView, spawnLocation);
        this.chestView.setUpModel(chestModel, this);
        this.stateManager = this.chestView.GetStateManager();
        this.chestPanelManager = chestPanelManager;

        ChestPanelManager.yesBtnClicked += YesButtonClicked;
        ChestPanelManager.noBtnClicked += NoButtonClicked;
    }

    ~ChestController(){
        Debug.Log("Destructor is called");
        ChestPanelManager.yesBtnClicked -= YesButtonClicked;
        ChestPanelManager.noBtnClicked -= NoButtonClicked;
    }

    void SpawnChest(ChestView chestView, Transform spawnSlot){
        this.chestView = GameObject.Instantiate<ChestView>(chestView, spawnSlot.position, spawnSlot.rotation);
        this.chestView.transform.SetParent(spawnSlot);
    }

    public void ManagePanel(){
        chestPanelManager.EnableObject(this);
        chestPanelManager.DisplayMessage(stateManager.GetDisplayStatement());
    }

    public void DestroyChest(){
        Debug.Log("Destroyed CHest");
        GameObject.Destroy(this.chestView.gameObject);
    }

    void YesButtonClicked(ChestController chestController){
        if(this.Equals(chestController)){
            Debug.Log("Same Object");
            Debug.Log("Yes Button CLicked");
            stateManager.YesButtonClicked();
        }
    }

    void NoButtonClicked(ChestController chestController){
        if(this.Equals(chestController)){
            Debug.Log("Same Object");
            Debug.Log("No Button Clicked");
            stateManager.NoButtonClicked();
        }
    }
}
