using System.Collections.Generic;
using ScriptableObjects;
using UnityEngine;

namespace Managers
{
    public class FusionManager : BaseManager<FusionManager>
    {
        [SerializeField] private float bonusMultiplier = 1.2f;

        public Card FuseCards(List<Card> inputCards)
        {
            if (inputCards == null || inputCards.Count < 2)
            {
                Debug.LogWarning("Fusion requires at least 2 cards.");
                return null;
            }

            int totalHealth = 0;
            int totalPower = 0;
            int highestMana = 0;

            foreach (var card in inputCards)
            {
                totalHealth += card.Health;
                totalPower += card.Power;
                if (card.ManaCost > highestMana)
                    highestMana = card.ManaCost;
            }

            int avgHealth = Mathf.RoundToInt((totalHealth / inputCards.Count) * bonusMultiplier);
            int scaledPower = Mathf.RoundToInt(totalPower * 0.8f);
            int finalMana = Mathf.Max(1, highestMana - 1);

            Card fusionCard = ScriptableObject.CreateInstance<Card>();

            typeof(Card).GetProperty("CardName").SetValue(fusionCard, "Fusion Card");
            typeof(Card).GetProperty("Health").SetValue(fusionCard, avgHealth);
            typeof(Card).GetProperty("Power").SetValue(fusionCard, scaledPower);
            typeof(Card).GetProperty("ManaCost").SetValue(fusionCard, finalMana);

            return fusionCard;
        }
    }
}