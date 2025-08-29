using System.Collections;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using UnityEngine;

public class LowBalance : MonoBehaviour
{
    public GameObject LowBalanceUI;

    public void Close()
    {
        LowBalanceUI.SetActive(false);
    }
}
