using System.Collections.Generic;
using UnityEngine;

namespace ScriptableObjects
{
    public class Card : ScriptableObject
    {
        [field: Header("Card Information")]
        [field: SerializeField] public string Name { get; private set; }
        [field: SerializeField] public Sprite Icon { get; private set; }
        
        [field: Header("Card Stats")]
        [field: SerializeField] public int Health { get; private set; }
        [field: SerializeField] public int Power { get; private set; }
        [field: SerializeField] public int ManaCost { get; private set; }
        
        [field: Header("Fusion Settings")]
        [field: SerializeField] public List<Card> ParentCards { get; private set; } = new List<Card>();
    }
}
