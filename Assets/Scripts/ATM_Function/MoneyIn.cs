using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyIn : MonoBehaviour
{
    public TMP_InputField InCustom;

    public GameObject LowCashUI;


    public void In(int amt)
    {
        if (GameManager.Instance.userData.cash < amt)
        {
            LowCashUI.SetActive(true);
        }
        else 
        { 
            GameManager.Instance.userData.balance = GameManager.Instance.userData.balance + amt;
            GameManager.Instance.userData.cash = GameManager.Instance.userData.cash - amt;
            GameManager.Instance.refresh();
        }
    }


    public void InCustom_Btn()
    {
        int amount = int.Parse(InCustom.text);

        In(amount);

    }
}

