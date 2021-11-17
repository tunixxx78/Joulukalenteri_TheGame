using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManager : MonoBehaviour
{
    [SerializeField] GameObject sled;
    DataHolder dataHolder;

    private void Awake()
    {
        dataHolder = FindObjectOfType<DataHolder>();
    }

    private void Update()
    {
        if(DataHolder.dataInstance.presentOne == true)
        {
            sled.SetActive(true);
        }
        else
        {
            sled.SetActive(false);
        }
    }
}
