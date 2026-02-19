using System.Collections.Generic;
using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "New Card", menuName = "Card")]
    public class Card : ScriptableObject
    {
        [field: Header("Card Information")]
        [field: SerializeField] public string CardName { get; private set; } = "Card Name";
        [field: SerializeField] public Sprite Icon { get; private set; }

        [field: Header("Card Stats")]
        [field: SerializeField, Range(1, 10)] public int Health { get; private set; } = 1;
        [field: SerializeField, Range(1, 10)] public int Power { get; private set; } = 1;
        [field: SerializeField, Range(1, 10)] public int ManaCost { get; private set; } = 1;
        
        [field: Header("Fusion Settings")]
        [field: SerializeField] public List<Card> ParentCards { get; private set; } = new List<Card>();
        
        [field: Header("Synergy Settings")]
        [field: SerializeField] public List<Card> SynergeticCards { get; private set; } = new List<Card>();
    }
}