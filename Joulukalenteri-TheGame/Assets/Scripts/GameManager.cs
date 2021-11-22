using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Date gameDate;
    [SerializeField]
    GameObject presentOne, presentTwo, presentThree, presentFour, presentFive, presentSix, presentSeven, presentEight, presentNine, presentTen, present11, present12, present13, present14, present15, present16, present17,
        present18, present19, present20, present21, present22, present23, present24;
    [SerializeField] GameObject presentOneOpened, presentTwoOpened, presentThreeOpened;
    [SerializeField] GameObject spawnPointOne, spawnPointTwo, spawnPointThree, spawnPointFour, spawnPointFive, spawnPointSix, spawnPointSeven, spawnPointEight, spawnPointNine, spawnPointTen, spawnPoint11, spawnPoint12, spawnPoint13, spawnPoint14,
        spawnPoint15, spawnPoint16, spawnPoint17, spawnPoint18, spawnPoint19, spawnPoint20, spawnPoint21, spawnPoint22, spawnPoint23, spawnPoint24;
    bool isSpawned = true, isSpawned2 = false, isSpawned3 = false, isSpawned4 = false, isSpawned5 = false, isSpawned6 = false, isSpawned7 = false, isSpawned8 = false, isSpawned9 = false, isSpawned10 = false, isSpawned11 = false, isSpawned12 = false, isSpawned13 = false,
        isSpawned14 = false, isSpawned15 = false, isSpawned16 = false, isSpawned17 = false, isSpawned18 = false, isSpawned19 = false, isSpawned20 = false, isSpawned21 = false, isSpawned22 = false, isSpawned23 = false, isSpawned24 = false;

    DataHolder dataHolder;

    private void Awake()
    {
        gameDate = FindObjectOfType<Date>();
        dataHolder = FindObjectOfType<DataHolder>();
    }

    private void Update()
    {
        DayOne();
        DayTwo();
        DayThree();
        DayFour();
        DayFive();
        DaySix();
        DaySeven();
        DayEight();
        DayNine();
        DayTen();
        Day11();
        Day12();
        Day13();
        Day14();
        Day15();
        Day16();
        Day17();
        Day18();
        Day19();
        Day20();
        Day21();
        Day22();
        Day23();
        Day24();

    }
    public void StartGameNow()
    {
        SceneManager.LoadScene("GameLevel");
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void PresentTwoSpawned()
    {
        if (DataHolder.dataInstance.presentTwoSpawned == false)
        {
            isSpawned2 = true;
        }
        
    }
    public void PresentThreeSpawned()
    {
        if (DataHolder.dataInstance.presentThreeSpawned == false)
        {
            isSpawned3 = true;
        }

    }
    public void PresentFourSpawned()
    {
        if(DataHolder.dataInstance.presentFourSpawned == false)
        {
            isSpawned4 = true;
        }
    }
    public void PresentFiveSpawned()
    {
        if (DataHolder.dataInstance.presentFiveSpawned == false)
        {
            isSpawned5 = true;
        }
    }
    public void PresentSixSpawned()
    {
        if (DataHolder.dataInstance.presentSixSpawned == false)
        {
            isSpawned6 = true;
        }
    }
    public void PresentSevenSpawned()
    {
        if (DataHolder.dataInstance.presentSevenSpawned == false)
        {
            isSpawned7 = true;
        }
    }
    public void PresentEightSpawned()
    {
        if (DataHolder.dataInstance.presentEightSpawned == false)
        {
            isSpawned8 = true;
        }
    }
    public void PresentNineSpawned()
    {
        if (DataHolder.dataInstance.presentNineSpawned == false)
        {
            isSpawned9 = true;
        }
    }
    public void PresentTenSpawned()
    {
        if (DataHolder.dataInstance.presentTenSpawned == false)
        {
            isSpawned10 = true;
        }
    }
    public void Present11Spawned()
    {
        if (DataHolder.dataInstance.present11Spawned == false)
        {
            isSpawned11 = true;
        }
    }
    public void Present12Spawned()
    {
        if (DataHolder.dataInstance.present12Spawned == false)
        {
            isSpawned12 = true;
        }
    }
    public void Present13Spawned()
    {
        if (DataHolder.dataInstance.present13Spawned == false)
        {
            isSpawned13 = true;
        }
    }
    public void Present14Spawned()
    {
        if (DataHolder.dataInstance.present14Spawned == false)
        {
            isSpawned14 = true;
        }
    }
    public void Present15Spawned()
    {
        if (DataHolder.dataInstance.present15Spawned == false)
        {
            isSpawned15 = true;
        }
    }
    public void Present16Spawned()
    {
        if (DataHolder.dataInstance.present16Spawned == false)
        {
            isSpawned16 = true;
        }
    }
    public void Present17Spawned()
    {
        if (DataHolder.dataInstance.present17Spawned == false)
        {
            isSpawned17 = true;
        }
    }
    public void Present18Spawned()
    {
        if (DataHolder.dataInstance.present18Spawned == false)
        {
            isSpawned18 = true;
        }
    }
    public void Present19Spawned()
    {
        if (DataHolder.dataInstance.present19Spawned == false)
        {
            isSpawned19 = true;
        }
    }
    public void Present20Spawned()
    {
        if (DataHolder.dataInstance.present20Spawned == false)
        {
            isSpawned20 = true;
        }
    }
    public void Present21Spawned()
    {
        if (DataHolder.dataInstance.present21Spawned == false)
        {
            isSpawned21 = true;
        }
    }
    public void Present22Spawned()
    {
        if (DataHolder.dataInstance.present22Spawned == false)
        {
            isSpawned22 = true;
        }
    }
    public void Present23Spawned()
    {
        if (DataHolder.dataInstance.present23Spawned == false)
        {
            isSpawned23 = true;
        }
    }
    public void Present24Spawned()
    {
        if (DataHolder.dataInstance.present24Spawned == false)
        {
            isSpawned4 = true;
        }
    }



    public void QuitGame()
    {
        Application.Quit();
    }

    void DayOne()
    {
        if (gameDate.dateInInt >= 1 && gameDate.dateInInt <= 24)
        {
            

            if (isSpawned && dataHolder.presentOne == false)
            {
                Debug.Log("T??ll?");
                if (gameDate.dateInInt >= 1)
                {
                    presentOne.SetActive(true);
                    //Instantiate(presentOne, spawnPointOne.transform.position, Quaternion.identity);
                    isSpawned = false;
                }
                else
                {
                    presentOne.SetActive(false);
                }
            }
            else if (dataHolder.presentOne == true && gameDate.dateInInt >= 1)
            {
                
                presentOneOpened.SetActive(true);
                presentOne.SetActive(false);
                presentTwo.SetActive(true);
            }
        }
        
        
        
    }
    void DayTwo()
    {
        if (gameDate.dateInInt >= 1 && gameDate.dateInInt <= 24)
        {
            if (isSpawned2 == true && dataHolder.presentTwo == false)
            {
                if (gameDate.dateInInt >= 2)
                {
                    presentTwo.SetActive(true);
                    //Instantiate(presentTwo, spawnPointTwo.transform.position, Quaternion.identity);
                    isSpawned2 = false;
                }
                else
                {
                    presentTwo.SetActive(false);
                }
            }
            else if (dataHolder.presentTwo == true && gameDate.dateInInt >= 2)
            {
                
                presentTwoOpened.SetActive(true);
                presentTwo.SetActive(false);
                presentThree.SetActive(true);
            }

        }
        
    }

    void DayThree()
    {
        if (gameDate.dateInInt >= 1 && gameDate.dateInInt <= 24)
        {
            
            if (isSpawned3 == true && dataHolder.presentThree == false)
            {
                Debug.Log("PASKAA");
                if (gameDate.dateInInt >= 3)
                {
                    //Instantiate(presentThree, spawnPointThree.transform.position, Quaternion.identity);
                    isSpawned3 = false;
                }
                else
                {
                    presentThree.SetActive(false);
                }
            }
            else if (dataHolder.presentThree == true && gameDate.dateInInt >= 3)
            {
                Debug.Log("PERSEEEEEEEEE");
                presentThreeOpened.SetActive(true);
                presentThree.SetActive(false);
                presentFour.SetActive(true);
            }
        }
    }
    void DayFour()
    {
        if (gameDate.dateInInt >= 1 && gameDate.dateInInt <= 24)
        {

            if (isSpawned4 == true)
            {
                Debug.Log("PASKAA");
                if (gameDate.dateInInt >= 4)
                {
                    Instantiate(presentFour, spawnPointFour.transform.position, Quaternion.identity);
                    isSpawned4 = false;
                }
            }
        }
    }
    void DayFive()
    {
        if (gameDate.dateInInt >= 1 && gameDate.dateInInt <= 24)
        {

            if (isSpawned5 == true)
            {
                Debug.Log("PASKAA");
                if (gameDate.dateInInt >= 5)
                {
                    Instantiate(presentFive, spawnPointFive.transform.position, Quaternion.identity);
                    isSpawned5 = false;
                }
            }
        }
    }
    void DaySix()
    {
        if (gameDate.dateInInt >= 1 && gameDate.dateInInt <= 24)
        {

            if (isSpawned6 == true)
            {
                Debug.Log("PASKAA");
                if (gameDate.dateInInt >= 6)
                {
                    Instantiate(presentSix, spawnPointSix.transform.position, Quaternion.identity);
                    isSpawned6 = false;
                }
            }
        }
    }
    void DaySeven()
    {
        if (gameDate.dateInInt >= 1 && gameDate.dateInInt <= 24)
        {

            if (isSpawned7 == true)
            {
                Debug.Log("PASKAA");
                if (gameDate.dateInInt >= 7)
                {
                    Instantiate(presentSeven, spawnPointSeven.transform.position, Quaternion.identity);
                    isSpawned7 = false;
                }
            }
        }
    }
    void DayEight()
    {
        if (gameDate.dateInInt >= 1 && gameDate.dateInInt <= 24)
        {

            if (isSpawned8 == true)
            {
                Debug.Log("PASKAA");
                if (gameDate.dateInInt >= 8)
                {
                    Instantiate(presentEight, spawnPointEight.transform.position, Quaternion.identity);
                    isSpawned8 = false;
                }
            }
        }
    }
    void DayNine()
    {
        if (gameDate.dateInInt >= 1 && gameDate.dateInInt <= 24)
        {

            if (isSpawned9 == true)
            {
                Debug.Log("PASKAA");
                if (gameDate.dateInInt >= 9)
                {
                    Instantiate(presentNine, spawnPointNine.transform.position, Quaternion.identity);
                    isSpawned9 = false;
                }
            }
        }
    }
    void DayTen()
    {
        if (gameDate.dateInInt >= 1 && gameDate.dateInInt <= 24)
        {

            if (isSpawned10 == true)
            {
                Debug.Log("PASKAA");
                if (gameDate.dateInInt >= 10)
                {
                    Instantiate(presentTen, spawnPointTen.transform.position, Quaternion.identity);
                    isSpawned10 = false;
                }
            }
        }
    }
    void Day11()
    {
        if (gameDate.dateInInt >= 1 && gameDate.dateInInt <= 24)
        {

            if (isSpawned11 == true)
            {
                Debug.Log("PASKAA");
                if (gameDate.dateInInt >= 11)
                {
                    Instantiate(present11, spawnPoint11.transform.position, Quaternion.identity);
                    isSpawned11 = false;
                }
            }
        }
    }
    void Day12()
    {
        if (gameDate.dateInInt >= 1 && gameDate.dateInInt <= 24)
        {

            if (isSpawned12 == true)
            {
                Debug.Log("PASKAA");
                if (gameDate.dateInInt >= 12)
                {
                    Instantiate(present12, spawnPoint12.transform.position, Quaternion.identity);
                    isSpawned12 = false;
                }
            }
        }
    }
    void Day13()
    {
        if (gameDate.dateInInt >= 1 && gameDate.dateInInt <= 24)
        {

            if (isSpawned13 == true)
            {
                Debug.Log("PASKAA");
                if (gameDate.dateInInt >= 13)
                {
                    Instantiate(present13, spawnPoint13.transform.position, Quaternion.identity);
                    isSpawned13 = false;
                }
            }
        }
    }
    void Day14()
    {
        if (gameDate.dateInInt >= 1 && gameDate.dateInInt <= 24)
        {

            if (isSpawned14 == true)
            {
                Debug.Log("PASKAA");
                if (gameDate.dateInInt >= 14)
                {
                    Instantiate(present14, spawnPoint14.transform.position, Quaternion.identity);
                    isSpawned14 = false;
                }
            }
        }
    }
    void Day15()
    {
        if (gameDate.dateInInt >= 1 && gameDate.dateInInt <= 24)
        {

            if (isSpawned15 == true)
            {
                Debug.Log("PASKAA");
                if (gameDate.dateInInt >= 15)
                {
                    Instantiate(present15, spawnPoint15.transform.position, Quaternion.identity);
                    isSpawned15 = false;
                }
            }
        }
    }
    void Day16()
    {
        if (gameDate.dateInInt >= 1 && gameDate.dateInInt <= 24)
        {

            if (isSpawned16 == true)
            {
                Debug.Log("PASKAA");
                if (gameDate.dateInInt >= 16)
                {
                    Instantiate(present16, spawnPoint16.transform.position, Quaternion.identity);
                    isSpawned16 = false;
                }
            }
        }
    }
    void Day17()
    {
        if (gameDate.dateInInt >= 1 && gameDate.dateInInt <= 24)
        {

            if (isSpawned17 == true)
            {
                Debug.Log("PASKAA");
                if (gameDate.dateInInt >= 17)
                {
                    Instantiate(present17, spawnPoint17.transform.position, Quaternion.identity);
                    isSpawned17 = false;
                }
            }
        }
    }
    void Day18()
    {
        if (gameDate.dateInInt >= 1 && gameDate.dateInInt <= 24)
        {

            if (isSpawned18 == true)
            {
                Debug.Log("PASKAA");
                if (gameDate.dateInInt >= 18)
                {
                    Instantiate(present18, spawnPoint18.transform.position, Quaternion.identity);
                    isSpawned18 = false;
                }
            }
        }
    }
    void Day19()
    {
        if (gameDate.dateInInt >= 1 && gameDate.dateInInt <= 24)
        {

            if (isSpawned19 == true)
            {
                Debug.Log("PASKAA");
                if (gameDate.dateInInt >= 19)
                {
                    Instantiate(present19, spawnPoint19.transform.position, Quaternion.identity);
                    isSpawned19 = false;
                }
            }
        }
    }
    void Day20()
    {
        if (gameDate.dateInInt >= 1 && gameDate.dateInInt <= 24)
        {

            if (isSpawned20 == true)
            {
                Debug.Log("PASKAA");
                if (gameDate.dateInInt >= 20)
                {
                    Instantiate(present20, spawnPoint20.transform.position, Quaternion.identity);
                    isSpawned20 = false;
                }
            }
        }
    }
    void Day21()
    {
        if (gameDate.dateInInt >= 1 && gameDate.dateInInt <= 24)
        {

            if (isSpawned21 == true)
            {
                Debug.Log("PASKAA");
                if (gameDate.dateInInt >= 21)
                {
                    Instantiate(present21, spawnPoint21.transform.position, Quaternion.identity);
                    isSpawned21 = false;
                }
            }
        }
    }
    void Day22()
    {
        if (gameDate.dateInInt >= 1 && gameDate.dateInInt <= 24)
        {

            if (isSpawned22 == true)
            {
                Debug.Log("PASKAA");
                if (gameDate.dateInInt >= 22)
                {
                    Instantiate(present22, spawnPoint22.transform.position, Quaternion.identity);
                    isSpawned22 = false;
                }
            }
        }
    }
    void Day23()
    {
        if (gameDate.dateInInt >= 1 && gameDate.dateInInt <= 24)
        {

            if (isSpawned23 == true)
            {
                Debug.Log("PASKAA");
                if (gameDate.dateInInt >= 23)
                {
                    Instantiate(present23, spawnPoint23.transform.position, Quaternion.identity);
                    isSpawned23 = false;
                }
            }
        }
    }
    void Day24()
    {
        if (gameDate.dateInInt >= 1 && gameDate.dateInInt <= 24)
        {

            if (isSpawned24 == true)
            {
                Debug.Log("PASKAA");
                if (gameDate.dateInInt >= 24)
                {
                    Instantiate(present24, spawnPoint24.transform.position, Quaternion.identity);
                    isSpawned24 = false;
                }
            }
        }
    }
}
