using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OutOfScreenIndicator : MonoBehaviour
{
    [SerializeField] Image outOfScreenImage;

    public void HideImage()
    {
        outOfScreenImage.enabled = false;
    }
}
