using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{

    public GameObject ATM;
    public GameObject MoneyIn;
    public GameObject MoneyOut;


    private void Awake()
    {
        // �г� �±׷� ã��
        ATM = GameObject.FindWithTag("ATM");
        MoneyIn = GameObject.FindWithTag("MoneyInUI");
        MoneyOut = GameObject.FindWithTag("MoneyOutUI");

        // ��ư �±׷� ã�� �� �̺�Ʈ ���
        GameObject.FindWithTag("MoneyIn_Btn").GetComponent<Button>().onClick.AddListener(OpenMoneyIN);
        GameObject.FindWithTag("MoneyOut_Btn").GetComponent<Button>().onClick.AddListener(OpenMoneyOut);
        GameObject.FindWithTag("InBack_Btn").GetComponent<Button>().onClick.AddListener(Back_In);
        GameObject.FindWithTag("OutBack_Btn").GetComponent<Button>().onClick.AddListener(Back_Out);

        // �ʱ� ���� ����
        ATM.SetActive(true);
        MoneyIn.SetActive(false);
        MoneyOut.SetActive(false);
    }

    public void OpenMoneyIN()
    {
        ATM.SetActive(false);
        MoneyIn.SetActive(true);
    }

    public void OpenMoneyOut()
    {
        ATM.SetActive(false);
        MoneyOut.SetActive(true);
    }


    public void Back_In()
    {
        MoneyIn.SetActive(false);
        ATM.SetActive(true);
    }

    public void Back_Out()
    {
        MoneyOut.SetActive(false);
        ATM.SetActive(true);
    }
}
