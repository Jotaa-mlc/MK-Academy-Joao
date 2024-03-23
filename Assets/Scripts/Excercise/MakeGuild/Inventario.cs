using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    int maxOfItems = 20;
    float coins;

    List<Items> ItemsInventory = new List<Items>();

    public List<Items> ShowItemsInventory()
    {
        List<Items> items = new List<Items>();

        foreach (var item in this.ItemsInventory)
        {
            items.Add(item);
        }

        return items;
    }
    public void ReceiveMoney(float value)
    {
        this.coins += value;
    }
    void GiveMoney2(float value, Inventory seller)
    {
        this.coins -= value;
        seller.ReceiveMoney(value);
    }
    public void ReceiveItem(Items item)
    {
        this.ItemsInventory.Add(item);
    }
    void GiveItem2(Items item, Inventory buyer)
    {
        if(buyer.ShowItemsInventory().Count + 1 <= maxOfItems)
        {
            this.ItemsInventory.Remove(item);
            buyer.ReceiveItem(item);
        }
    }
    public void Sell(Items item, Inventory buyer)
    {
        buyer.Buy(item, this);
    }

    void Buy(Items item, Inventory seller)
    {
        this.GiveMoney2(2.4f, seller);
    }
}
