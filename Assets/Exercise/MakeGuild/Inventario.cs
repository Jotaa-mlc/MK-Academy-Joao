using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Progress;

public class Inventory
{
    int maxOfItems = 20;
    float coins;

    List<Items> ItemsInventory;

    public void PrintAllInfo()
    {
        Debug.Log($"Moedas: {this.coins}");
        if (this.ItemsInventory.Count != 0)
        {
            foreach (var item in this.ItemsInventory)
            {
                item.PrintItem();
            }
        }
        else
        {
            Debug.Log("Inventário vazio!");
        }
    }
    public void ReceiveMoney(float value)
    {
        this.coins += value;
    }
    bool GiveMoney2(float value, Inventory seller)
    {
        if(value <= this.coins)
        {
            this.coins -= value;
            seller.ReceiveMoney(value);
            return true;
        }
        return false;
    }
    public bool ReceiveItem(Items item)
    {
        bool recieved = false;
        if (this.ItemsInventory.Count <= maxOfItems)
        {
            this.ItemsInventory.Add(item);
            recieved = true;
        }
        return recieved;
    }
    void GiveItem2(Items item, Inventory buyer)
    {
        if (buyer.ReceiveItem(item))
        {
            this.ItemsInventory.Remove(item);
        }
    }
    public void Sell(Items item, Inventory buyer)
    {
        if(buyer.GiveMoney2(item.Value, this))
        {
            this.GiveItem2(item, buyer);
        }
    }
    public Inventory (float _coins, List<Items> _items = null)
    {
        this.coins = _coins;
        this.ItemsInventory = _items == null ? new List<Items>() : _items;
    }
}