using System.Collections.Generic;
using ScriptableObjects;
using UnityEngine;

namespace Managers
{
    public class CardDatabaseManager : BaseManager<CardDatabaseManager>
    {
        [SerializeField] private List<Card> allCards = new List<Card>();

        private Dictionary<string, Card> cardLookup = new Dictionary<string, Card>();

        protected override void Initialize()
        {
            foreach (var card in allCards)
            {
                if (!cardLookup.ContainsKey(card.CardName))
                    cardLookup.Add(card.CardName, card);
            }
        }

        public Card GetCardByName(string name)
        {
            cardLookup.TryGetValue(name, out var card);
            return card;
        }

        public List<Card> GetAllCards()
        {
            return allCards;
        }
    }
}