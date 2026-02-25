using UnityEngine;
using UnityEngine.SceneManagement;

namespace UI
{
    public class ButtonActionPlay : ButtonAction
    {
        [SerializeField] private string deckSceneName = "DeckCreation";

        protected override void DoAction()
        {
            // Optionally add fade out or button animation before scene load
            SceneManager.LoadScene(deckSceneName);
        }
    }
}