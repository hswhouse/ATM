using System.Collections;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using UnityEngine;

public class LowCash : MonoBehaviour
{
    public GameObject LowCashUI;

    public void Close()
    {
        LowCashUI.SetActive(false);
    }
}
