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
    [SerializeField] GameObject presentOneOpened, presentTwoOpened, presentThreeOpened, presentFourOpened, presentFiveOpened, presentSixOpened, presentSevenOpened, presentEightOpened, presentNineOpened, presentTenOpened, present11Opened, present12Opened, present13Opened,
        present14Opened, present15Opened, present16Opened, present17Opened, present18Opened, present19Opened, present20Opened, present21Opened, present22Opened, present23Opened, present24Opened;
    GameObject spawnPointOne, spawnPointTwo, spawnPointThree, spawnPointFour, spawnPointFive, spawnPointSix, spawnPointSeven, spawnPointEight, spawnPointNine, spawnPointTen, spawnPoint11, spawnPoint12, spawnPoint13, spawnPoint14,
        spawnPoint15, spawnPoint16, spawnPoint17, spawnPoint18, spawnPoint19, spawnPoint20, spawnPoint21, spawnPoint22, spawnPoint23, spawnPoint24;
    bool isSpawned = true, isSpawned2 = false, isSpawned3 = false, isSpawned4 = false, isSpawned5 = false, isSpawned6 = false, isSpawned7 = false, isSpawned8 = false, isSpawned9 = false, isSpawned10 = false, isSpawned11 = false, isSpawned12 = false, isSpawned13 = false,
        isSpawned14 = false, isSpawned15 = false, isSpawned16 = false, isSpawned17 = false, isSpawned18 = false, isSpawned19 = false, isSpawned20 = false, isSpawned21 = false, isSpawned22 = false, isSpawned23 = false, isSpawned24 = false;

    [SerializeField] float maxDay = 30;

    [SerializeField] GameObject waitForNextDay;
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
        Time.timeScale = 0;
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
            if(gameDate.dateInInt < 2)
            {
                waitForNextDay.SetActive(true);
                Time.timeScale = 0;
            }
        }
        
    }
    public void PresentThreeSpawned()
    {
        if (DataHolder.dataInstance.presentThreeSpawned == false)
        {
            isSpawned3 = true;
            if (gameDate.dateInInt <= 3)
            {
                waitForNextDay.SetActive(true);
                Time.timeScale = 0;
            }
        }

    }
    public void PresentFourSpawned()
    {
        if(DataHolder.dataInstance.presentFourSpawned == false)
        {
            isSpawned4 = true;
            if (gameDate.dateInInt <= 4)
            {
                waitForNextDay.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
    public void PresentFiveSpawned()
    {
        if (DataHolder.dataInstance.presentFiveSpawned == false)
        {
            isSpawned5 = true;
            if (gameDate.dateInInt <= 5)
            {
                waitForNextDay.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
    public void PresentSixSpawned()
    {
        if (DataHolder.dataInstance.presentSixSpawned == false)
        {
            isSpawned6 = true;
            if (gameDate.dateInInt <= 6)
            {
                waitForNextDay.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
    public void PresentSevenSpawned()
    {
        if (DataHolder.dataInstance.presentSevenSpawned == false)
        {
            isSpawned7 = true;
            if (gameDate.dateInInt <= 7)
            {
                waitForNextDay.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
    public void PresentEightSpawned()
    {
        if (DataHolder.dataInstance.presentEightSpawned == false)
        {
            isSpawned8 = true;
            if (gameDate.dateInInt <= 8)
            {
                waitForNextDay.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
    public void PresentNineSpawned()
    {
        if (DataHolder.dataInstance.presentNineSpawned == false)
        {
            isSpawned9 = true;
            if (gameDate.dateInInt <= 9)
            {
                waitForNextDay.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
    public void PresentTenSpawned()
    {
        if (DataHolder.dataInstance.presentTenSpawned == false)
        {
            isSpawned10 = true;
            if (gameDate.dateInInt <= 10)
            {
                waitForNextDay.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
    public void Present11Spawned()
    {
        if (DataHolder.dataInstance.present11Spawned == false)
        {
            isSpawned11 = true;
            if (gameDate.dateInInt <= 11)
            {
                waitForNextDay.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
    public void Present12Spawned()
    {
        if (DataHolder.dataInstance.present12Spawned == false)
        {
            isSpawned12 = true;
            if (gameDate.dateInInt <= 12)
            {
                waitForNextDay.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
    public void Present13Spawned()
    {
        if (DataHolder.dataInstance.present13Spawned == false)
        {
            isSpawned13 = true;
            if (gameDate.dateInInt <= 13)
            {
                waitForNextDay.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
    public void Present14Spawned()
    {
        if (DataHolder.dataInstance.present14Spawned == false)
        {
            isSpawned14 = true;
            if (gameDate.dateInInt <= 14)
            {
                waitForNextDay.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
    public void Present15Spawned()
    {
        if (DataHolder.dataInstance.present15Spawned == false)
        {
            isSpawned15 = true;
            if (gameDate.dateInInt <= 15)
            {
                waitForNextDay.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
    public void Present16Spawned()
    {
        if (DataHolder.dataInstance.present16Spawned == false)
        {
            isSpawned16 = true;
            if (gameDate.dateInInt <= 16)
            {
                waitForNextDay.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
    public void Present17Spawned()
    {
        if (DataHolder.dataInstance.present17Spawned == false)
        {
            isSpawned17 = true;
            if (gameDate.dateInInt <= 17)
            {
                waitForNextDay.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
    public void Present18Spawned()
    {
        if (DataHolder.dataInstance.present18Spawned == false)
        {
            isSpawned18 = true;
            if (gameDate.dateInInt <= 18)
            {
                waitForNextDay.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
    public void Present19Spawned()
    {
        if (DataHolder.dataInstance.present19Spawned == false)
        {
            isSpawned19 = true;
            if (gameDate.dateInInt <= 19)
            {
                waitForNextDay.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
    public void Present20Spawned()
    {
        if (DataHolder.dataInstance.present20Spawned == false)
        {
            isSpawned20 = true;
            if (gameDate.dateInInt <= 20)
            {
                waitForNextDay.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
    public void Present21Spawned()
    {
        if (DataHolder.dataInstance.present21Spawned == false)
        {
            isSpawned21 = true;
            if (gameDate.dateInInt <= 21)
            {
                waitForNextDay.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
    public void Present22Spawned()
    {
        if (DataHolder.dataInstance.present22Spawned == false)
        {
            isSpawned22 = true;
            if (gameDate.dateInInt <= 22)
            {
                waitForNextDay.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
    public void Present23Spawned()
    {
        if (DataHolder.dataInstance.present23Spawned == false)
        {
            isSpawned23 = true;
            if (gameDate.dateInInt <= 23)
            {
                waitForNextDay.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
    public void Present24Spawned()
    {
        if (DataHolder.dataInstance.present24Spawned == false)
        {
            isSpawned4 = true;
            if (gameDate.dateInInt <= 24)
            {
                waitForNextDay.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }



    public void QuitGame()
    {
        Application.Quit();
    }

    void DayOne()
    {
        if (gameDate.dateInInt >= 1 && gameDate.dateInInt <= maxDay)
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
                if (dataHolder.presentTwo == false && gameDate.dateInInt >= 2) { presentTwo.SetActive(true); }
                
            }
            
        }
        
        
        
        
    }
    void DayTwo()
    {
        if (gameDate.dateInInt >= 1 && gameDate.dateInInt <= maxDay)
        {
            //presentTwo.SetActive(false);

            if (isSpawned2 == true && dataHolder.presentTwo == false && gameDate.dateInInt >= 2)
            {
                Debug.Log("VOIHAN VITTU!");
                if (gameDate.dateInInt >= 2)
                {
                    presentTwo.SetActive(true);
                    //Instantiate(presentTwo, spawnPointTwo.transform.position, Quaternion.identity);
                    isSpawned2 = true;
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
                if (dataHolder.presentThree == false && gameDate.dateInInt >= 3) { presentThree.SetActive(true); }
            }
            

        }
        
    }

    void DayThree()
    {
        if (gameDate.dateInInt >= 1 && gameDate.dateInInt <= maxDay)
        {
            
            if (isSpawned3 == true && dataHolder.presentThree == false && gameDate.dateInInt >= 3)
            {
                Debug.Log("PASKAA");
                if (gameDate.dateInInt >= 3)
                {
                    presentThree.SetActive(true);
                    //Instantiate(presentThree, spawnPointThree.transform.position, Quaternion.identity);
                    isSpawned3 = true;
                }
                else
                {
                    presentThree.SetActive(false);
                }
            }
            else if (dataHolder.presentThree == true && gameDate.dateInInt >= 3)
            {
                
                presentThreeOpened.SetActive(true);
                presentThree.SetActive(false);
                if (dataHolder.presentFour == false && gameDate.dateInInt >= 4) { presentFour.SetActive(true); }
            }
        }
    }
    void DayFour()
    {
        if (gameDate.dateInInt >= 1 && gameDate.dateInInt <= maxDay)
        {

            if (isSpawned4 == true && dataHolder.presentFour == false && gameDate.dateInInt >= 4)
            {
                Debug.Log("PASKAA");
                if (gameDate.dateInInt >= 4)
                {
                    presentFour.SetActive(true);
                    //Instantiate(presentFour, spawnPointFour.transform.position, Quaternion.identity);
                    isSpawned4 = false;
                }
                else
                {
                    presentThree.SetActive(false);
                }
            }
            else if (dataHolder.presentFour == true && gameDate.dateInInt >= 4)
            {
                Debug.Log("PERSEEEEEEEEE");
                presentFourOpened.SetActive(true);
                presentFour.SetActive(false);
                if (dataHolder.presentFive == false && gameDate.dateInInt >= 5) { presentFive.SetActive(true); }
            }
        }
        
    }
    void DayFive()
    {
        if (gameDate.dateInInt >= 1 && gameDate.dateInInt <= maxDay)
        {

            if (isSpawned5 == true && dataHolder.presentFive == false && gameDate.dateInInt >= 5)
            {
                Debug.Log("PASKAA");
                if (gameDate.dateInInt >= 5)
                {
                    presentFive.SetActive(true);
                    //Instantiate(presentFive, spawnPointFive.transform.position, Quaternion.identity);
                    isSpawned5 = false;
                }
                else
                {
                    presentFive.SetActive(false);
                }
            }
            else if (dataHolder.presentFive == true && gameDate.dateInInt >= 5)
            {
                presentFiveOpened.SetActive(true);
                presentFive.SetActive(false);
                if (dataHolder.presentSix == false && gameDate.dateInInt >= 6) { presentSix.SetActive(true); }
            }
        }
    }
    void DaySix()
    {
        if (gameDate.dateInInt >= 1 && gameDate.dateInInt <= maxDay)
        {

            if (isSpawned6 == true && dataHolder.presentSix == false && gameDate.dateInInt >= 6)
            {
                Debug.Log("PASKAA");
                if (gameDate.dateInInt >= 6)
                {
                    presentSix.SetActive(true);
                    //Instantiate(presentSix, spawnPointSix.transform.position, Quaternion.identity);
                    isSpawned6 = false;
                }
                else { presentSix.SetActive(false); }
            }
            else if (dataHolder.presentSix == true && gameDate.dateInInt >= 6)
            {
                presentSixOpened.SetActive(true);
                presentSix.SetActive(false);
                if (dataHolder.presentSeven == false && gameDate.dateInInt >= 7) { presentSeven.SetActive(true); }
            }
        }
    }
    void DaySeven()
    {
        if (gameDate.dateInInt >= 1 && gameDate.dateInInt <= maxDay)
        {

            if (isSpawned7 == true && dataHolder.presentSeven == false && gameDate.dateInInt >= 7)
            {
                Debug.Log("PASKAA");
                if (gameDate.dateInInt >= 7)
                {
                    presentSeven.SetActive(true);
                    //Instantiate(presentSeven, spawnPointSeven.transform.position, Quaternion.identity);
                    isSpawned7 = false;
                }
                else { presentSeven.SetActive(false); }
            }
            else if (dataHolder.presentSeven == true && gameDate.dateInInt >= 7)
            {
                presentSevenOpened.SetActive(true);
                presentSeven.SetActive(false);
                if (dataHolder.presentEight == false && gameDate.dateInInt >= 8) { presentEight.SetActive(true); }
            }
        }
    }
    void DayEight()
    {
        if (gameDate.dateInInt >= 1 && gameDate.dateInInt <= maxDay)
        {

            if (isSpawned8 == true && dataHolder.presentEight == false && gameDate.dateInInt >= 8)
            {
                Debug.Log("PASKAA");
                if (gameDate.dateInInt >= 8)
                {
                    presentEight.SetActive(true);
                    //Instantiate(presentEight, spawnPointEight.transform.position, Quaternion.identity);
                    isSpawned8 = false;
                }
                else { presentEight.SetActive(false); }
            }
            else if (dataHolder.presentEight == true && gameDate.dateInInt >= 8)
            {
                presentEightOpened.SetActive(true);
                presentEight.SetActive(false);
                if (dataHolder.presentNine == false && gameDate.dateInInt >= 9) { presentNine.SetActive(true); }
            }
        }
    }
    void DayNine()
    {
        if (gameDate.dateInInt >= 1 && gameDate.dateInInt <= maxDay)
        {

            if (isSpawned9 == true && dataHolder.presentNine == false && gameDate.dateInInt >= 9)
            {
                Debug.Log("PASKAA");
                if (gameDate.dateInInt >= 9)
                {
                    presentNine.SetActive(true);
                    //Instantiate(presentNine, spawnPointNine.transform.position, Quaternion.identity);
                    isSpawned9 = false;
                }
                else { presentNine.SetActive(false); }
            }
            else if(dataHolder.presentNine == true && gameDate.dateInInt >= 9)
            {
                presentNineOpened.SetActive(true);
                presentNine.SetActive(false);
                if (dataHolder.presentTen == false && gameDate.dateInInt >= 10) { presentTen.SetActive(true); }
            }
        }
    }
    void DayTen()
    {
        if (gameDate.dateInInt >= 1 && gameDate.dateInInt <= maxDay)
        {

            if (isSpawned10 == true && dataHolder.presentTen == false && gameDate.dateInInt >= 10)
            {
                Debug.Log("PASKAA");
                if (gameDate.dateInInt >= 10)
                {
                    presentTen.SetActive(true);
                    //Instantiate(presentTen, spawnPointTen.transform.position, Quaternion.identity);
                    isSpawned10 = false;
                }
                else { presentTen.SetActive(false); }
            }
            else if (dataHolder.presentTen == true && gameDate.dateInInt >= 10)
            {
                presentTenOpened.SetActive(true);
                presentTen.SetActive(false);
                if (dataHolder.present11 == false && gameDate.dateInInt >= 11) { present11.SetActive(true); }
            }
        }
    }
    void Day11()
    {
        if (gameDate.dateInInt >= 1 && gameDate.dateInInt <= maxDay)
        {

            if (isSpawned11 == true && dataHolder.present11 == false && gameDate.dateInInt >= 11)
            {
                Debug.Log("PASKAA");
                if (gameDate.dateInInt >= 11)
                {
                    present11.SetActive(true);
                    //Instantiate(present11, spawnPoint11.transform.position, Quaternion.identity);
                    isSpawned11 = false;
                }
                else { present11.SetActive(false); }
            }
            else if (dataHolder.present11 == true && gameDate.dateInInt >= 11)
            {
                present11Opened.SetActive(true);
                present11.SetActive(false);
                if (dataHolder.present12 == false && gameDate.dateInInt >= 12) { present12.SetActive(true); }
            }
        }
    }
    void Day12()
    {
        if (gameDate.dateInInt >= 1 && gameDate.dateInInt <= maxDay)
        {

            if (isSpawned12 == true && dataHolder.present12 == false && gameDate.dateInInt >= 12)
            {
                Debug.Log("PASKAA");
                if (gameDate.dateInInt >= 12)
                {
                    present12.SetActive(true);
                    //Instantiate(present12, spawnPoint12.transform.position, Quaternion.identity);
                    isSpawned12 = false;
                }
                else { present12.SetActive(false); }
            }
            else if (dataHolder.present12 == true && gameDate.dateInInt >= 12)
            {
                present12Opened.SetActive(true);
                present12.SetActive(false);
                if (dataHolder.present13 == false && gameDate.dateInInt >= 13) { present13.SetActive(true); }
            }
        }
    }
    void Day13()
    {
        if (gameDate.dateInInt >= 1 && gameDate.dateInInt <= maxDay)
        {

            if (isSpawned13 == true && dataHolder.present13 == false && gameDate.dateInInt >= 13)
            {
                Debug.Log("PASKAA");
                if (gameDate.dateInInt >= 13)
                {
                    present13.SetActive(true);
                    //Instantiate(present13, spawnPoint13.transform.position, Quaternion.identity);
                    isSpawned13 = false;
                }
                else { present13.SetActive(false); }
            }
            else if (dataHolder.present13 == true && gameDate.dateInInt >= 13)
            {
                present13Opened.SetActive(true);
                present13.SetActive(false);
                if (dataHolder.present14 == false && gameDate.dateInInt >= 14) { present14.SetActive(true); }
            }
        }
    }
    void Day14()
    {
        if (gameDate.dateInInt >= 1 && gameDate.dateInInt <= maxDay)
        {

            if (isSpawned14 == true && dataHolder.present14 == false && gameDate.dateInInt >= 14)
            {
                Debug.Log("PASKAA");
                if (gameDate.dateInInt >= 14)
                {
                    present14.SetActive(true);
                    //Instantiate(present14, spawnPoint14.transform.position, Quaternion.identity);
                    isSpawned14 = false;
                }
                else { present14.SetActive(false); }
            }
            else if(dataHolder.present14 == true && gameDate.dateInInt >= 14)
            {
                present14Opened.SetActive(true);
                present14.SetActive(false);
                if (dataHolder.present15 == false && gameDate.dateInInt >= 15) { present15.SetActive(true); }
            }
        }
    }
    void Day15()
    {
        if (gameDate.dateInInt >= 1 && gameDate.dateInInt <= maxDay)
        {

            if (isSpawned15 == true && dataHolder.present15 == false && gameDate.dateInInt >= 15)
            {
                Debug.Log("PASKAA");
                if (gameDate.dateInInt >= 15)
                {
                    present15.SetActive(true);
                    //Instantiate(present15, spawnPoint15.transform.position, Quaternion.identity);
                    isSpawned15 = false;
                }
                else { present15.SetActive(false); }
            }
            else if (dataHolder.present15 == true && gameDate.dateInInt >= 15)
            {
                present15Opened.SetActive(true);
                present15.SetActive(false);
                if (dataHolder.present16 == false && gameDate.dateInInt >= 16) { present16.SetActive(true); }
            }
        }
    }
    void Day16()
    {
        if (gameDate.dateInInt >= 1 && gameDate.dateInInt <= maxDay)
        {

            if (isSpawned16 == true && dataHolder.present16 == false && gameDate.dateInInt >= 16)
            {
                Debug.Log("PASKAA");
                if (gameDate.dateInInt >= 16)
                {
                    present16.SetActive(true);
                    //Instantiate(present16, spawnPoint16.transform.position, Quaternion.identity);
                    isSpawned16 = false;
                }
                else { present16.SetActive(false); }
            }
            else if (dataHolder.present16 == true && gameDate.dateInInt >= 16)
            {
                present16Opened.SetActive(true);
                present16.SetActive(false);
                if (dataHolder.present17 == false && gameDate.dateInInt >= 17) { present17.SetActive(true); }
            }
        }
    }
    void Day17()
    {
        if (gameDate.dateInInt >= 1 && gameDate.dateInInt <= maxDay)
        {

            if (isSpawned17 == true && dataHolder.present17 == false && gameDate.dateInInt >= 17)
            {
                Debug.Log("PASKAA");
                if (gameDate.dateInInt >= 17)
                {
                    present17.SetActive(true);
                    //Instantiate(present17, spawnPoint17.transform.position, Quaternion.identity);
                    isSpawned17 = false;
                }
                else { present17.SetActive(false); }
            }
            else if (dataHolder.present17 == true && gameDate.dateInInt >= 17)
            {
                present17Opened.SetActive(true);
                present17.SetActive(false);
                if (dataHolder.present18 == false && gameDate.dateInInt >= 18) { present18.SetActive(true); }
            }
        }
    }
    void Day18()
    {
        if (gameDate.dateInInt >= 1 && gameDate.dateInInt <= maxDay)
        {

            if (isSpawned18 == true && dataHolder.present18 == false && gameDate.dateInInt >= 18)
            {
                Debug.Log("PASKAA");
                if (gameDate.dateInInt >= 18)
                {
                    present18.SetActive(true);
                    //Instantiate(present18, spawnPoint18.transform.position, Quaternion.identity);
                    isSpawned18 = false;
                }
                else { present18.SetActive(false); }
            }
            else if (dataHolder.present18 == true && gameDate.dateInInt >= 18)
            {
                present18Opened.SetActive(true);
                present18.SetActive(false);
                if (dataHolder.present19 == false && gameDate.dateInInt >= 19) { present19.SetActive(true); }
            }
        }
    }
    void Day19()
    {
        if (gameDate.dateInInt >= 1 && gameDate.dateInInt <= maxDay)
        {

            if (isSpawned19 == true && dataHolder.present19 == false && gameDate.dateInInt >= 19)
            {
                Debug.Log("PASKAA");
                if (gameDate.dateInInt >= 19)
                {
                    present19.SetActive(true);
                    //Instantiate(present19, spawnPoint19.transform.position, Quaternion.identity);
                    isSpawned19 = false;
                }
                else { present19.SetActive(false); }
            }
            else if (dataHolder.present19 == true && gameDate.dateInInt >= 19)
            {
                present19Opened.SetActive(true);
                present19.SetActive(false);
                if (dataHolder.present20 == false && gameDate.dateInInt >= 20) { present20.SetActive(true); }
            }
        }
    }
    void Day20()
    {
        if (gameDate.dateInInt >= 1 && gameDate.dateInInt <= maxDay)
        {

            if (isSpawned20 == true && dataHolder.present20 == false && gameDate.dateInInt >= 20)
            {
                Debug.Log("PASKAA");
                if (gameDate.dateInInt >= 20)
                {
                    present20.SetActive(true);
                    //Instantiate(present20, spawnPoint20.transform.position, Quaternion.identity);
                    isSpawned20 = false;
                }
                else { present20.SetActive(false); }
            }
            else if (dataHolder.present20 == true && gameDate.dateInInt >= 20)
            {
                present20Opened.SetActive(true);
                present20.SetActive(false);
                if (dataHolder.present21 == false && gameDate.dateInInt >= 21) { present21.SetActive(true); }
            }
        }
    }
    void Day21()
    {
        if (gameDate.dateInInt >= 1 && gameDate.dateInInt <= maxDay)
        {

            if (isSpawned21 == true && dataHolder.present21 == false && gameDate.dateInInt >= 21)
            {
                Debug.Log("PASKAA");
                if (gameDate.dateInInt >= 21)
                {
                    present21.SetActive(true);
                    //Instantiate(present21, spawnPoint21.transform.position, Quaternion.identity);
                    isSpawned21 = false;
                }
                else { present21.SetActive(false); }
            }
            else if (dataHolder.present21 == true && gameDate.dateInInt >= 21)
            {
                present21Opened.SetActive(true);
                present21.SetActive(false);
                if (dataHolder.present22 == false && gameDate.dateInInt >= 22) { present22.SetActive(true); }
            }
        }
    }
    void Day22()
    {
        if (gameDate.dateInInt >= 1 && gameDate.dateInInt <= maxDay)
        {

            if (isSpawned22 == true && dataHolder.present22 == false && gameDate.dateInInt >= 22)
            {
                Debug.Log("PASKAA");
                if (gameDate.dateInInt >= 22)
                {
                    present22.SetActive(true);
                    //Instantiate(present22, spawnPoint22.transform.position, Quaternion.identity);
                    isSpawned22 = false;
                }
                else { present22.SetActive(false); }
            }
            else if (dataHolder.present22 == true && gameDate.dateInInt >= 22)
            {
                present22Opened.SetActive(true);
                present22.SetActive(false);
                if (dataHolder.present23 == false && gameDate.dateInInt >= 23) { present23.SetActive(true); }
            }
        }
    }
    void Day23()
    {
        if (gameDate.dateInInt >= 1 && gameDate.dateInInt <= maxDay)
        {

            if (isSpawned23 == true && dataHolder.present23 == false && gameDate.dateInInt >= 23)
            {
                Debug.Log("PASKAA");
                if (gameDate.dateInInt >= 23)
                {
                    present23.SetActive(true);
                    //Instantiate(present23, spawnPoint23.transform.position, Quaternion.identity);
                    isSpawned23 = false;
                }
                else { present23.SetActive(false); }
            }
            else if (dataHolder.present23 == true && gameDate.dateInInt >= 23)
            {
                present23Opened.SetActive(true);
                present23.SetActive(false);
                if (dataHolder.present24 == false && gameDate.dateInInt >= 24) { present24.SetActive(true); }
            }
        }
    }
    void Day24()
    {
        if (gameDate.dateInInt >= 1 && gameDate.dateInInt <= maxDay)
        {

            if (isSpawned24 == true && dataHolder.present24 == false && gameDate.dateInInt >= 24)
            {
                Debug.Log("PASKAA");
                if (gameDate.dateInInt >= 24)
                {
                    present24.SetActive(true);
                    //Instantiate(present24, spawnPoint24.transform.position, Quaternion.identity);
                    isSpawned24 = false;
                }
                else { present24.SetActive(false); }
            }
            else if (dataHolder.present24 == true && gameDate.dateInInt >= 24)
            {
                present24Opened.SetActive(true);
                present24.SetActive(false);
                
            }
        }
    }
}
