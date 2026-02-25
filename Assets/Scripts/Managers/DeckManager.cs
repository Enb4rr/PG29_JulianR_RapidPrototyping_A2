using System.Collections.Generic;
using ScriptableObjects;
using UnityEngine;

namespace Managers
{
    public class DeckManager : BaseManager<DeckManager>
    {
        private List<Deck> runtimeDecks = new List<Deck>();

        public Deck CreateNewDeck(string deckName)
        {
            Deck newDeck = ScriptableObject.CreateInstance<Deck>();
            typeof(Deck).GetProperty("DeckName").SetValue(newDeck, deckName);
            runtimeDecks.Add(newDeck);
            return newDeck;
        }

        public bool AddCardToDeck(Deck deck, Card card)
        {
            int copiesInDeck = CountCardInDeck(deck, card);

            if (copiesInDeck >= 2)
            {
                Debug.LogWarning("Cannot add more than 2 copies of the same card.");
                return false;
            }

            deck.Cards.Add(card);
            return true;
        }

        public void RemoveCardFromDeck(Deck deck, Card card)
        {
            deck.Cards.Remove(card);
        }

        public int CountCardInDeck(Deck deck, Card card)
        {
            int count = 0;
            foreach (var c in deck.Cards)
            {
                if (c == card)
                    count++;
            }
            return count;
        }

        public int GetDeckSize(Deck deck)
        {
            return deck.Cards.Count;
        }
    }
}