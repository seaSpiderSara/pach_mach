using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;
using TMPro;

public class moneyManage : MonoBehaviour
{
    public static moneyManage instance;

    public  int mainCash = 25;
    public int cashChange;
    public TextMeshProUGUI mainCashDisp;
    public GameObject debt;
    public KeyCode wasteMoney = KeyCode.Space;

    //allowing elements of this code to be called in other objects
    private void Awake()
    {
        instance = this;
    }

    public void Start()
    {
        mainCashDisp.text = "Your cash: " + mainCash.ToString() + " coins.";
        debt.SetActive(false);
    }

    public void Update()
    {
        if (Input.GetKeyDown(wasteMoney))
        {
            mainCash -= 5;
            mainCashDisp.text = "Your cash: " + mainCash.ToString() + " coins.";
        }

        if (mainCash <= -1)
        {
            debt.SetActive(true);
        }
        else
        {
            debt.SetActive(false);
        }
    }

    public void AddPoint()
    {
        mainCash += cashChange;
        mainCashDisp.text = "Your cash: " + mainCash.ToString() + " coins.";
    }

    
        
    
}
