using UnityEngine;

public class SingltonBehaviour<T> : MonoBehaviour where T : SingltonBehaviour<T>
{
    public static T instance { get; private set; }

    private void Awake() {
        if(instance != null) Destroy(this);

        instance = (T)this;
        DontDestroyOnLoad(this);
    }
}
