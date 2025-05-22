using UnityEngine;

public enum ItemType
{
    Weapon,
    Armor,
    Potion
}

public class ItemData : ScriptableObject
{
    public string itemName;
    public ItemType type;
}
