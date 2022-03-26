using UnityEditor;
using UnityEngine;
[System.Serializable]
public class Reward
{
    public delegate int GetValue();
    [System.Serializable]
    struct range{
        [SerializeField] public int min;
        [SerializeField] public int max;
        public int getValue(){
            return Random.Range(min, max);
        }
    }

    [SerializeField]
    range coins;
    [SerializeField]
    range gems;
    public int getCoin(){
        return coins.getValue();
    }
    public int getGem(){
        return gems.getValue();
    }
}
