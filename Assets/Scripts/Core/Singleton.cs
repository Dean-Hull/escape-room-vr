using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : Component
{
    private static T _instance;

    public static T Instance 
    {
        get 
        {
            if (_instance == null) 
            {
                GameObject go = new GameObject();
                go.name = typeof(T).Name;
                _instance = go.AddComponent<T>();
            }
            return _instance;
        }
    }

    private void OnDestroy() 
    {
        if (_instance == this)
        {
            _instance = null;
        }
    }
}

public class PersistentSingleton<T> : MonoBehaviour where T : Component
{
    private static T _instance;

    public static T Instance 
    {
        get 
        {
            return _instance;
        }
    }

    private void OnDestroy() 
    {
        if (_instance == this)
        {
            _instance = null;
        }
    }

    public virtual void Awake()
    {
        if (_instance == null)
        {
            _instance =  this as T;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(this);
        }
    }
}