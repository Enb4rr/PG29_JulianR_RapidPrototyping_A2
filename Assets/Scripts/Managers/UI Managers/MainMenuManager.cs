using DG.Tweening;
using UnityEngine;

namespace Managers.UI_Managers
{
    public class MainMenuManager : MonoBehaviour
    {
        [Header("UI Panels")]
        [SerializeField] private CanvasGroup titlePanel;
        [SerializeField] private CanvasGroup mainMenuPanel;

        [Header("Animation Settings")]
        [SerializeField] private float fadeDuration = 0.5f;
        [SerializeField] private float slideDistance = 50f;

        private void OnEnable()
        {
            PlayIntroAnimation();
        }

        private void PlayIntroAnimation()
        {
            // Reset panels
            titlePanel.alpha = 0;
            mainMenuPanel.alpha = 0;

            titlePanel.transform.localPosition += Vector3.up * slideDistance;
            mainMenuPanel.transform.localPosition -= Vector3.up * slideDistance;

            // Create animation sequence
            Sequence seq = DOTween.Sequence();

            // Title: slide down + fade in
            seq.Append(titlePanel.transform.DOLocalMoveY(titlePanel.transform.localPosition.y - slideDistance, fadeDuration)
                .SetEase(Ease.OutCubic));
            seq.Join(titlePanel.DOFade(1f, fadeDuration));

            // Menu: slide up + fade in after title
            seq.Append(mainMenuPanel.transform.DOLocalMoveY(mainMenuPanel.transform.localPosition.y + slideDistance, fadeDuration)
                .SetEase(Ease.OutCubic));
            seq.Join(mainMenuPanel.DOFade(1f, fadeDuration));

            seq.Play();
        }
    }
}