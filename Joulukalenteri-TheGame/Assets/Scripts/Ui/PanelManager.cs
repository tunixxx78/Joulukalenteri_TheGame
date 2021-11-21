using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManager : MonoBehaviour
{
    [SerializeField] GameObject Day1, Day2, Day3, Day4, Day5, Day6, Day7, Day8, Day9, Day10, Day11, Day12, Day13, Day14, Day15, Day16, Day17, Day18, Day19, Day20, Day21, Day22, Day23, Day24;
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
        PresentFour();
        presentFive();
        presentSix();
        presentEight();
        presentNine();
        presentTen();
        present11();
        present12();
        present13();
        present14();
        present15();
        present16();
        present17();
        present18();
        present19();
        present20();
        present21();
        present22();
        present23();
        present24();


    }

    void PresentOne()
    {
        if (DataHolder.dataInstance.presentOne == true)
        {
            Day1.SetActive(true);
        }
        else
        {
            Day1.SetActive(false);
        }
    }

    void PresentTwo()
    {
        if (DataHolder.dataInstance.presentTwo == true)
        {
            Day2.SetActive(true);
        }
        else
        {
            Day2.SetActive(false);
        }
    }
    void PresentThree()
    {
        if (DataHolder.dataInstance.presentThree == true)
        {
            Day3.SetActive(true);
        }
        else
        {
            Day3.SetActive(false);
        }
    }
    void PresentFour()
    {
        if(DataHolder.dataInstance.presentFour == true)
        {
            Day4.SetActive(true);
        }
        else
        {
            Day4.SetActive(false);
        }
    }
    void presentFive()
    {
        if (DataHolder.dataInstance.presentFive == true)
        {
            Day5.SetActive(true);
        }
        else
        {
            Day5.SetActive(false);
        }
    }
    void presentSix()
    {
        if (DataHolder.dataInstance.presentSix == true)
        {
            Day6.SetActive(true);
        }
        else
        {
            Day6.SetActive(false);
        }
    }
    void presentSeven()
    {
        if (DataHolder.dataInstance.presentSeven == true)
        {
            Day7.SetActive(true);
        }
        else
        {
            Day7.SetActive(false);
        }
    }
    void presentEight()
    {
        if (DataHolder.dataInstance.presentEight == true)
        {
            Day8.SetActive(true);
        }
        else
        {
            Day8.SetActive(false);
        }
    }
    void presentNine()
    {
        if (DataHolder.dataInstance.presentNine == true)
        {
            Day9.SetActive(true);
        }
        else
        {
            Day9.SetActive(false);
        }
    }
    void presentTen()
    {
        if (DataHolder.dataInstance.presentTen == true)
        {
            Day10.SetActive(true);
        }
        else
        {
            Day10.SetActive(false);
        }
    }
    void present11()
    {
        if (DataHolder.dataInstance.present11 == true)
        {
            Day11.SetActive(true);
        }
        else
        {
            Day11.SetActive(false);
        }
    }
    void present12()
    {
        if (DataHolder.dataInstance.present12 == true)
        {
            Day12.SetActive(true);
        }
        else
        {
            Day12.SetActive(false);
        }
    }
    void present13()
    {
        if (DataHolder.dataInstance.present13 == true)
        {
            Day13.SetActive(true);
        }
        else
        {
            Day13.SetActive(false);
        }
    }
    void present14()
    {
        if (DataHolder.dataInstance.presentFour == true)
        {
            Day14.SetActive(true);
        }
        else
        {
            Day14.SetActive(false);
        }
    }
    void present15()
    {
        if (DataHolder.dataInstance.presentFour == true)
        {
            Day15.SetActive(true);
        }
        else
        {
            Day15.SetActive(false);
        }
    }
    void present16()
    {
        if (DataHolder.dataInstance.presentFour == true)
        {
            Day16.SetActive(true);
        }
        else
        {
            Day16.SetActive(false);
        }
    }
    void present17()
    {
        if (DataHolder.dataInstance.presentFour == true)
        {
            Day17.SetActive(true);
        }
        else
        {
            Day17.SetActive(false);
        }
    }
    void present18()
    {
        if (DataHolder.dataInstance.presentFour == true)
        {
            Day18.SetActive(true);
        }
        else
        {
            Day18.SetActive(false);
        }
    }
    void present19()
    {
        if (DataHolder.dataInstance.presentFour == true)
        {
            Day19.SetActive(true);
        }
        else
        {
            Day19.SetActive(false);
        }
    }
    void present20()
    {
        if (DataHolder.dataInstance.presentFour == true)
        {
            Day20.SetActive(true);
        }
        else
        {
            Day20.SetActive(false);
        }
    }
    void present21()
    {
        if (DataHolder.dataInstance.presentFour == true)
        {
            Day21.SetActive(true);
        }
        else
        {
            Day21.SetActive(false);
        }
    }
    void present22()
    {
        if (DataHolder.dataInstance.presentFour == true)
        {
            Day22.SetActive(true);
        }
        else
        {
            Day22.SetActive(false);
        }
    }
    void present23()
    {
        if (DataHolder.dataInstance.presentFour == true)
        {
            Day23.SetActive(true);
        }
        else
        {
            Day23.SetActive(false);
        }
    }
    void present24()
    {
        if (DataHolder.dataInstance.presentFour == true)
        {
            Day24.SetActive(true);
        }
        else
        {
            Day24.SetActive(false);
        }
    }
}
