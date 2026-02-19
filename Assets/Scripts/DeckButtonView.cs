using ScriptableObjects;
using TMPro;
using UnityEngine;

public class DeckButtonView : MonoBehaviour
{
    public TMP_Text nameText;

    private DeckData deck;
    private DeckBuilderManager manager;

    public void Setup(DeckData deck, DeckBuilderManager manager)
    {
        this.deck = deck;
        this.manager = manager;

        nameText.text = deck.deckName;
    }

    public void OnClick()
    {
        manager.SelectDeck(deck);
    }
}