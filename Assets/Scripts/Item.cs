using UnityEngine;

public class Item : MonoBehaviour
{
    public int qty;
    public ItemData data;

    public Item(int qty, ItemData data)
    {
        this.qty = qty;
        this.data = data;
    }

}

