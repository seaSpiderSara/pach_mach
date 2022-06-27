using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;
using TMPro;

public class moneyManage : MonoBehaviour
{
    public int mainCash = 25;
    public TextMeshProUGUI mainCashDisp;

    public void Start()
    {
        mainCashDisp.text = "Your cash: " + mainCash.ToString();

    }
}
