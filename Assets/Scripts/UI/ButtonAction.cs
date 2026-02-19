using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public abstract class ButtonAction : MonoBehaviour
    {
        private void OnEnable()
        {
            if (TryGetComponent(out Button button))
            {
                button.onClick.AddListener(DoAction);
            }
        }

        private void OnDisable()
        {
            if (TryGetComponent(out Button button))
            {
                button.onClick.RemoveListener(DoAction);
            }
        }

        protected virtual void DoAction()
        {
            
        }
    }
}
