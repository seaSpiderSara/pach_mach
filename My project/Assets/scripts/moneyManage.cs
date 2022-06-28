using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;
using TMPro;

public class moneyManage : MonoBehaviour
{
    public static moneyManage instance;

    public int mainCash = 25;
    public int cashChange;
    public TextMeshProUGUI mainCashDisp;
    public KeyCode wasteMoney = KeyCode.Space;

    //allowing elements of this code to be called in other objects
    private void Awake()
    {
        instance = this;
    }

    public void Start()
    {
        mainCashDisp.text = "Your cash: " + mainCash.ToString();
    }

    public void Update()
    {
        if (Input.GetKeyDown(wasteMoney))
        {
            mainCash -= 5;
            mainCashDisp.text = "Your cash: " + mainCash.ToString();
        }

        if (mainCash == 0)
        {

        }
    }

    public void AddPoint()
    {
        mainCash += 5;
        mainCashDisp.text = "Your cash: " + mainCash.ToString();
    }

    
        
    
}
