using UnityEngine;

public class SingltonBehaviour<T> : MonoBehaviour where T : SingltonBehaviour<T>
{
    public T instance { get; private set; }

    private void Awake() {
        instance = (T)this;
        DontDestroyOnLoad(this);
    }
}
