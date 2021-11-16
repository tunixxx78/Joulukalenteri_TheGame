using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIIndicatorContreoller : MonoBehaviour
{
    public Canvas canvas;
    public List<TargetIndicator> targetIndicators = new List<TargetIndicator>();
    public Camera mainCamera;
    public GameObject targetIndicatorPrefab;

    private void Update()
    {
        if (targetIndicators.Count > 0)
        {
            for(int i = 0; i < targetIndicators.Count; i++)
            {
                targetIndicators[i].UpdateTargetIndicator();
            }
        }
    }

    public void AddTargetIndicator(GameObject target)
    {
        TargetIndicator indicator = GameObject.Instantiate(targetIndicatorPrefab, canvas.transform).GetComponent<TargetIndicator>();
        indicator.InitialiseTargetIndicator(target, mainCamera, canvas);
        targetIndicators.Add(indicator);
    }
}
