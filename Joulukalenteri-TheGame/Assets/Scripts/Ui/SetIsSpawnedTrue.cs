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

    public void SetIsSpawnedToTrue()
    {
        gameManager.IsSpawnedToTrue();
    }
}
