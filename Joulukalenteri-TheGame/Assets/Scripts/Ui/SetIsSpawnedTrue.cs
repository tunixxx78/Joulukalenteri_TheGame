using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetIsSpawnedTrue : MonoBehaviour
{
    GameManager gameManager;

    private void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    public void PresentTwo()
    {
        gameManager.PresentTwoSpawned();
    }
    public void PresentThree()
    {
        gameManager.PresentThreeSpawned();
    }
    public void PresentFour()
    {
        gameManager.PresentFourSpawned();
    }
}
