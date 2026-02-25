using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;

namespace UI
{
    [RequireComponent(typeof(RectTransform))]
    public class ButtonHoverEffect : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        [SerializeField] private float hoverScale = 1.1f;
        [SerializeField] private float animDuration = 0.2f;

        private Vector3 originalScale;

        private void Awake()
        {
            originalScale = transform.localScale;
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            transform.DOScale(originalScale * hoverScale, animDuration).SetEase(Ease.OutBack);
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            transform.DOScale(originalScale, animDuration).SetEase(Ease.OutBack);
        }
    }
}