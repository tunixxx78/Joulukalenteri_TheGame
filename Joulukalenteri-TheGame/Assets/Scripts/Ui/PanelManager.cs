using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManager : MonoBehaviour
{
    [SerializeField] GameObject sled, elf, reindeer, gift;
    DataHolder dataHolder;

    private void Awake()
    {
        dataHolder = FindObjectOfType<DataHolder>();
    }

    private void Update()
    {

        PresentOne();
        PresentTwo();
        PresentThree();
        presentFour();
        
    }

    void PresentOne()
    {
        if (DataHolder.dataInstance.presentOne == true)
        {
            sled.SetActive(true);
        }
        else
        {
            sled.SetActive(false);
        }
    }

    void PresentTwo()
    {
        if (DataHolder.dataInstance.presentTwo == true)
        {
            elf.SetActive(true);
        }
        else
        {
            elf.SetActive(false);
        }
    }
    void PresentThree()
    {
        if (DataHolder.dataInstance.presentThree == true)
        {
            reindeer.SetActive(true);
        }
        else
        {
            reindeer.SetActive(false);
        }
    }
    void presentFour()
    {
        if(DataHolder.dataInstance.presentFour == true)
        {
            gift.SetActive(true);
        }
        else
        {
            gift.SetActive(false);
        }
    }
}
