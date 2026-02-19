using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "New Deck", menuName = "Deck")]
    public class Deck : ScriptableObject
    {
        [field: SerializeField] public string DeckName { get; private set; } = "Default";
        [field: SerializeField] public int DeckID { get; private set; } = 0;
        [field: SerializeField] public List<Card> Cards {get; private set;} = new List<Card>();
    }
}
