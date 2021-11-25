using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToNextDay : MonoBehaviour
{
    DataHolder dataHolder;

    private void Awake()
    {
        dataHolder = FindObjectOfType<DataHolder>();
    }

    public void WaitForNextDay()
    {
        dataHolder.SaveData();
        Time.timeScale = 1;
    }
}
