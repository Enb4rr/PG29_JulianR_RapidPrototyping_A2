using ScriptableObjects;
using UnityEngine;
using TMPro;

namespace UI
{
    public class DeckView : MonoBehaviour
    {
        [SerializeField] private TMP_Text deckNameText;
        [SerializeField] private TMP_Text cardCountText;

        private Deck deck;

        public void Initialize(Deck deckData)
        {
            deck = deckData;
            Refresh();
        }

        public void Refresh()
        {
            deckNameText.text = deck.DeckName;
            cardCountText.text = $"Cards: {deck.Cards.Count}";
        }
    }
}