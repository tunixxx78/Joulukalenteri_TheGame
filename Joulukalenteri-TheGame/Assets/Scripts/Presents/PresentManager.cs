using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PresentManager : MonoBehaviour
{
    [SerializeField] GameObject picture;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            picture.SetActive(true);
            Debug.Log("Osuma");
        }
    }
}
