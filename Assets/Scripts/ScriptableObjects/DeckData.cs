using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(menuName = "Cards/Deck Data")]
    public class DeckData : ScriptableObject
    {
        public string deckName;
        public CardData[] cards = new CardData[6];
    }
}