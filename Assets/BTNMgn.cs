using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BTNMgn : MonoBehaviour
{
    public GameObject BK;

    public  Button InputVic;

    public Text textTitle;
    public Text context;
    public GameObject prefab;
    public Transform parent;
    // Start is called before the first frame update
    void Start()
    {
        InputVic.onClick.AddListener(InputV);

        for(int i=0; i<4;i++)
        {
            GameObject item = Instantiate(prefab);
            item.transform.parent=parent;
            item.transform.localPosition = new Vector3(0,i*10,0);
            item.name =$"{i}";
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void InputStart(string Title)
    {
     textTitle.text =Title;
     //context.text =contect;
     BK.SetActive(true);
    }
    public void InputV()
    {
        BK.SetActive(false);
    }
}
