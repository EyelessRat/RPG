using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private BattleManager battleManager;
    [SerializeField] private InventoryManager inventoryManager;
    [SerializeField] private Transform potionContainer;
    [SerializeField] private GameObject potionButton;

    public void OnClickDamageEnemy()
    {
        EnemyControler.DamageEnemyAction(player.GetPlayerDamage());
        battleManager.NextTurn();
    }


    public void OnClickDefend()
    {
        player.isDefending = true;
        battleManager.NextTurn();   
    }


    public void OnClickLoadPotions()
    {
        foreach (Transform child in potionContainer)
        {
            Destroy(child.gameObject);
        }

        for (int i = 0; i < inventoryManager.items.Count; i++)
        {
            Item item = inventoryManager.items[i];
            if (item.data.type == ItemType.Potion)
            {
                GameObject button = Instantiate(potionButton, potionContainer);
                button.GetComponentInChildren<TextMeshProUGUI>().text = item.data.name;
                button.GetComponent<Button>().onClick.AddListener(() => OnClickUsePotion((PotionData)item.data));
            }
        }
    }


    public void OnClickUsePotion(PotionData potion)
    {
        Debug.Log(potion.name);
        potionContainer.gameObject.SetActive(false);
        battleManager.NextTurn();
    }
}
