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
        // 패널 태그로 찾기
        ATM = GameObject.FindWithTag("ATM");
        MoneyIn = GameObject.FindWithTag("MoneyInUI");
        MoneyOut = GameObject.FindWithTag("MoneyOutUI");

        // 버튼 태그로 찾기 후 이벤트 등록
        GameObject.FindWithTag("MoneyIn_Btn").GetComponent<Button>().onClick.AddListener(OpenMoneyIN);
        GameObject.FindWithTag("MoneyOut_Btn").GetComponent<Button>().onClick.AddListener(OpenMoneyOut);
        GameObject.FindWithTag("InBack_Btn").GetComponent<Button>().onClick.AddListener(Back_In);
        GameObject.FindWithTag("OutBack_Btn").GetComponent<Button>().onClick.AddListener(Back_Out);

        // 초기 상태 설정
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
