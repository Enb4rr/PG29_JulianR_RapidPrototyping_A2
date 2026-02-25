using System.Collections.Generic;
using ScriptableObjects;
using UnityEngine;

namespace Managers
{
    public class CollectionManager : BaseManager<CollectionManager>
    {
        [SerializeField] private Inventory playerInventory;

        private Dictionary<Card, int> ownedCardCounts = new Dictionary<Card, int>();

        protected override void Initialize()
        {
            InitializeCollection();
        }

        private void InitializeCollection()
        {
            ownedCardCounts.Clear();

            foreach (var card in CardDatabaseManager.Instance.GetAllCards())
            {
                ownedCardCounts[card] = 3;
            }
        }

        public int GetOwnedCopies(Card card)
        {
            return ownedCardCounts.TryGetValue(card, out int count) ? count : 0;
        }

        public Dictionary<Card, int> GetFullCollection()
        {
            return ownedCardCounts;
        }
    }
}