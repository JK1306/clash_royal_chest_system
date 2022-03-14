using UnityEngine;
[System.Serializable]
public class Reward
{
    [System.Serializable]
    struct range{
        [SerializeField] int min;
        [SerializeField] int max;
    }

    [SerializeField]
    range coins;
    [SerializeField]
    range gems;
}
