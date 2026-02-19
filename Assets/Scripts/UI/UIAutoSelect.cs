using UnityEngine;
using UnityEngine.EventSystems;

namespace UI
{
    public class UIAutoSelect : MonoBehaviour, IPointerEnterHandler
    {
        [SerializeField] private bool firstSelected = false;

        private void OnEnable()
        {
            if (firstSelected) SelectElement();
        }

        // Called when pointer moves over UI element
        public void OnPointerEnter(PointerEventData eventData)
        {
            SelectElement();
        }

        public void SelectElement()
        {
            EventSystem.current.SetSelectedGameObject(null);
            EventSystem.current.SetSelectedGameObject(gameObject);
        }
    }
}
