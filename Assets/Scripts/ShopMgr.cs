using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopMgr : MonoBehaviour
{
    public Card_hander card_Hander;
    public SpriteMgr spriteMgr;

    public GameObject PrefabSource;
    public GameObject pool;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnGUI()
    {

        if (GUI.Button(new Rect(10, 70, 50, 30), "Click"))
        {
         card_Hander.Amount =1;
         card_Hander.Shopitem =spriteMgr.sprites[0];
         card_Hander.Product ="快篩試劑";
         card_Hander.Cost =180;
        }
        if (GUI.Button(new Rect(10, 100, 50, 30), "+"))
        {
         GameObject targrt=Instantiate(PrefabSource);
         targrt.transform.parent=pool.transform;
         //重製
         targrt.transform.localScale = Vector3.one;
         //塞文字
         Card_hander _card=targrt.GetComponent<Card_hander>();
         _card.Amount=(int)Random.Range(100,999);
         _card.Shopitem=spriteMgr.sprites[(int)Random.Range(0,4)];
         _card.Product="快篩試劑"+(int)Random.Range(0,4);
         _card.Cost=(int)Random.Range(100,180);
        }
           
    }
}
