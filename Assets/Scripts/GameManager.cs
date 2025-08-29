using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    static GameManager gameManager;
    public UserData userData;
    public TMP_Text Balance;
    public TMP_Text CashNum;
    public TMP_Text Name;

    public static GameManager Instance
    {
        get { return gameManager; }
    }
    private void Awake()
    {
        gameManager = this;
        LoadUserData();
        refresh();
    }

    public void refresh()
    {
        Name.text = userData.UserName;
        Balance.text = string.Format("balance: {0:N0}", userData.balance);
        CashNum.text = string.Format("Çö±Ý \n\n{0:N0}",userData.cash);
        SaveUserData();
    }

    public void SaveUserData()
    {
        string path = Application.persistentDataPath + "/playerData.json";
        string json = JsonUtility.ToJson(userData);
        File.WriteAllText(path, json);
        
    }


    public void LoadUserData()
    {
        string path = Application.persistentDataPath + "/playerData.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            userData = JsonUtility.FromJson<UserData>(json);
        }
        else
            userData = new UserData("a",1,1);
    }
    
}