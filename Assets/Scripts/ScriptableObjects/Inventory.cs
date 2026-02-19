using System.Collections.Generic;
using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "New Inventory", menuName = "Inventory")]
    public class Inventory : ScriptableObject
    {
        [field: SerializeField] public List<Card> OwnedCards { get; private set; } = new List<Card>();
        [field: SerializeField] public List<Deck> OwnedDecks { get; private set; } = new List<Deck>();
    }
}
