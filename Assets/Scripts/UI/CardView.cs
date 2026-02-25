using ScriptableObjects;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace UI
{
    public class CardView : MonoBehaviour
    {
        [SerializeField] private Image icon;
        [SerializeField] private TMP_Text nameText;
        [SerializeField] private TMP_Text healthText;
        [SerializeField] private TMP_Text powerText;
        [SerializeField] private TMP_Text manaText;

        private Card currentCard;

        public void Initialize(Card card)
        {
            currentCard = card;
            icon.sprite = card.Icon;
            nameText.text = card.CardName;
            healthText.text = $"HP: {card.Health}";
            powerText.text = $"POW: {card.Power}";
            manaText.text = $"MANA: {card.ManaCost}";
        }
    }
}