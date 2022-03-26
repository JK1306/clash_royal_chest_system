using UnityEngine;

public class SingltonBehaviour<T> : MonoBehaviour where T : SingltonBehaviour<T>
{
    public static T instance { get; private set; }

    public virtual void Awake() {
        if(instance != null){
            Destroy(this);
            return;
        }
        instance = (T)this;
        DontDestroyOnLoad(this);
    }
}
