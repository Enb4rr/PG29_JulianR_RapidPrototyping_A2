using ScriptableObjects;
using TMPro;
using UnityEngine;

public class CardView : MonoBehaviour
{
    public TMP_Text nameText;
    private CardData data;

    private DeckBuilderManager manager;

    public void Setup(CardData data, DeckBuilderManager manager)
    {
        this.data = data;
        this.manager = manager;

        nameText.text = data != null ? data.cardName : "Empty";
    }

    public void OnClick()
    {
        manager.OnCardClicked(this);
    }

    public CardData GetData()
    {
        return data;
    }
}