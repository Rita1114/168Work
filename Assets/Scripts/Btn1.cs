
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Btn1 : MonoBehaviour
{
    public  Button BTNopen;
    public BtnMgn1 msgHandler;

    // Start is called before the first frame update
    void Start()
    {
        BTNopen.onClick.AddListener(OnBKopen);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnBKopen()
    {
        msgHandler.InputStart("12345");
    }
    
    
}