using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetObject : MonoBehaviour
{
    private void Awake()
    {
        UIIndicatorContreoller ui = GetComponentInParent<UIIndicatorContreoller>();
        if (ui == null)
        {
            ui = GameObject.Find("World").GetComponent<UIIndicatorContreoller>();
        }

        if (ui == null) Debug.LogError("No UIController component found");

        ui.AddTargetIndicator(this.gameObject);
    }
}
