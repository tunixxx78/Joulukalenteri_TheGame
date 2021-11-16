using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowPointerForGifts : MonoBehaviour
{
    Vector3 targetPosition;
    RectTransform pointerRectTransform;
    [SerializeField]private Camera uICamera;
    

    private void Awake()
    {
        targetPosition = new Vector3(150, 0, 100);
        pointerRectTransform = transform.Find("Pointer").GetComponent<RectTransform>();
    }

    private void Update()
    {
        Vector3 toPosition = targetPosition;
        Vector3 fromPosition = Camera.main.transform.position;
        fromPosition.y = 0f;

        Vector3 dir = (toPosition - fromPosition).normalized;

        float angle = Mathf.Atan2(dir.z, dir.x) * Mathf.Rad2Deg;
        if (angle < 0) angle += 360;

        pointerRectTransform.localEulerAngles = new Vector3(0, 0, angle);

        float borderSize = 1f;
        Vector3 targetPositionScreenPoint = Camera.main.WorldToScreenPoint(targetPosition);
        bool isOffScreen = targetPositionScreenPoint.x <= borderSize || targetPositionScreenPoint.x >= Screen.width - borderSize || targetPositionScreenPoint.z <= borderSize || targetPositionScreenPoint.z >= Screen.height- borderSize;

        if (isOffScreen)
        {
            Vector3 cappedTargetScreenPosition = targetPositionScreenPoint;
            if (cappedTargetScreenPosition.x <= borderSize) cappedTargetScreenPosition.x = borderSize;
            if (cappedTargetScreenPosition.x >= Screen.width- borderSize) cappedTargetScreenPosition.x = Screen.width - borderSize;
            if (cappedTargetScreenPosition.z <= borderSize) cappedTargetScreenPosition.z = borderSize;
            if (cappedTargetScreenPosition.z >= Screen.height - borderSize) cappedTargetScreenPosition.z = Screen.height - borderSize;

            Vector3 pointerWorldPosition = uICamera.ScreenToWorldPoint(cappedTargetScreenPosition);
            pointerRectTransform.position = pointerWorldPosition;
            pointerRectTransform.localPosition = new Vector3(pointerRectTransform.localPosition.x, 0f,  pointerRectTransform.localPosition.z);
        }
    }
}
