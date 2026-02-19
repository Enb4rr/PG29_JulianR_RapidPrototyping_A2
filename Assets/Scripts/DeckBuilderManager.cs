using ScriptableObjects;
using UnityEngine;
using UnityEngine.UI;

public class DeckBuilderManager : MonoBehaviour
{
    [Header("Data")]
    public DeckData[] availableDecks;
    public CardData[] collectionCards;

    [Header("UI References")]
    public DeckButtonView[] deckButtons;
    public CardView[] deckCardSlots;
    public CardView[] collectionCardSlots;

    public CardView comparisonDeckCard;
    public CardView comparisonCollectionCard;

    public Button switchButton;

    private DeckData currentDeck;
    private CardView selectedDeckCard;
    private CardView selectedCollectionCard;
    private int selectedDeckCardIndex;

    void Start()
    {
        LoadDeckButtons();
        LoadCollection();
        switchButton.interactable = false;
    }

    // ----------- LOADERS ------------

    void LoadDeckButtons()
    {
        for (int i = 0; i < deckButtons.Length; i++)
        {
            deckButtons[i].Setup(availableDecks[i], this);
        }
    }

    void LoadCollection()
    {
        for (int i = 0; i < collectionCardSlots.Length; i++)
        {
            collectionCardSlots[i].Setup(collectionCards[i], this);
        }
    }

    void LoadDeckCards()
    {
        for (int i = 0; i < deckCardSlots.Length; i++)
        {
            deckCardSlots[i].Setup(currentDeck.cards[i], this);
        }
    }

    // ----------- DECK SELECTION ------------

    public void SelectDeck(DeckData deck)
    {
        currentDeck = deck;
        LoadDeckCards();

        ClearSelection();
    }

    // ----------- CARD CLICK ------------

    public void OnCardClicked(CardView card)
    {
        // Check if card belongs to deck
        int deckIndex = System.Array.IndexOf(deckCardSlots, card);

        if (deckIndex >= 0)
        {
            SelectDeckCard(deckIndex, card);
            return;
        }

        // Otherwise collection
        SelectCollectionCard(card);
    }

    void SelectDeckCard(int index, CardView card)
    {
        selectedDeckCardIndex = index;
        selectedDeckCard = card;

        comparisonDeckCard.Setup(card.GetData(), this);
        UpdateSwitchButton();
    }

    void SelectCollectionCard(CardView card)
    {
        selectedCollectionCard = card;

        comparisonCollectionCard.Setup(card.GetData(), this);
        UpdateSwitchButton();
    }

    // ----------- SWITCH ------------

    void UpdateSwitchButton()
    {
        switchButton.interactable =
            selectedDeckCard != null &&
            selectedCollectionCard != null;
    }

    public void SwitchCards()
    {
        if (currentDeck == null) return;

        currentDeck.cards[selectedDeckCardIndex] =
            selectedCollectionCard.GetData();

        LoadDeckCards();
        ClearSelection();
    }

    // ----------- RESET ------------

    void ClearSelection()
    {
        selectedDeckCard = null;
        selectedCollectionCard = null;

        comparisonDeckCard.Setup(null, this);
        comparisonCollectionCard.Setup(null, this);

        switchButton.interactable = false;
    }
}