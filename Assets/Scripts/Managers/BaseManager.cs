using UnityEngine;

namespace Managers
{
    public abstract class BaseManager<T> : MonoBehaviour where T : MonoBehaviour
    {
        public static T Instance { get; private set; }
        
        [SerializeField] private bool initializeOnAwake = false;
        [SerializeField] private bool initializeOnStart = false;

        protected virtual void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
                return;
            }

            Instance = this as T;
            DontDestroyOnLoad(gameObject);
            
            if (initializeOnAwake) Initialize();
        }
        
        protected virtual void Start()
        {
            if (initializeOnStart) Initialize();
        }

        protected virtual void Initialize() { }
    }
}