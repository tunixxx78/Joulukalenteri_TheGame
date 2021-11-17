using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScratchingGrid : MonoBehaviour
{
    [SerializeField] int rows = 6, cols = 6;
    [SerializeField] float tileSize = 1;

    private void Start()
    {
        GenerateGrid();
    }

    void GenerateGrid()
    {
        GameObject referenceTile = (GameObject)Instantiate(Resources.Load("ScratchTile"));

        for(int row = 0; row < rows; row++)
        {
            for(int col = 0; col< cols; col++)
            {
                GameObject tile = (GameObject)Instantiate(referenceTile, transform);

                float posX = col * tileSize;
                float posY = row * tileSize;

                tile.transform.position = new Vector2(posX, posY);
            }
        }
        Destroy(referenceTile);

        float gridW = cols * tileSize;
        float gridH = rows * tileSize;

        transform.position = new Vector2(-gridW / 2 + tileSize / 2, gridH / 2 - tileSize / 2);
    }
}
