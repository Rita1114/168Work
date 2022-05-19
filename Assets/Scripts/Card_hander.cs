using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card_hander : MonoBehaviour
{
    public Image Image_ShopItem;
    public Text Text_Amount;
    public Text Text_Product;
    public Text Text_Cost;


    private int _amount = 0;
    public int Amount
    {
        get { return _amount; }
        set
        {
            _amount = value;
            isDirty = true;
        }
    }

    public bool isDirty;
    // Start is called before the first frame update
    void Start()
    {

    }
    private Sprite _shopitem;
    public Sprite Shopitem
    {
        get { return _shopitem; }
        set
        {
            _shopitem = value;
            isDirty = true;
        }
    }

    private string  _Product;
    public string Product
    {
        get { return _Product; }
        set
        {
            _Product = value;
            isDirty = true;
        }
    }
    private int _cost;
    public int Cost
    {
        get { return _cost; }
        set
        {
            _cost = value;
            isDirty = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (isDirty)
        {
            Text_Amount.text = Amount.ToString(); //數量

            Text_Cost.text =_cost.ToString();//錢

            Text_Product.text =_Product;//產品
            if(_shopitem!=null)
            {
                Image_ShopItem.sprite=_shopitem;
            }
            isDirty = false;
        }


    }
}
