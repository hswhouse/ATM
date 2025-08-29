using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyOut : MonoBehaviour
{
    public TMP_InputField OutCustom;

    public GameObject LowBalanceUI;


    public void Out(int amt)
    {
        if (GameManager.Instance.userData.balance < amt)
        {
            LowBalanceUI.SetActive(true);
        }
        else
        {
            GameManager.Instance.userData.balance = GameManager.Instance.userData.balance - amt;
            GameManager.Instance.userData.cash = GameManager.Instance.userData.cash + amt;
            GameManager.Instance.refresh();
        }
    }


    public void OutCustom_Btn()
    {
        int amount = int.Parse(OutCustom.text);

        Out(amount);

    }
}