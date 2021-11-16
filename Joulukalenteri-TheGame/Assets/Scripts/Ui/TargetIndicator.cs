using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetIndicator : MonoBehaviour
{
    public Image targetIndicatorImage;
    public Image offscreenTargetIndicator;
    public float OutOfSightOffset = 20f;
    private float outOfSightOffset { get { return OutOfSightOffset; } }

    private GameObject target;
    private Camera mainCamera;
    private RectTransform canvasRect;
    private RectTransform rectTransform;

    

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    public void InitialiseTargetIndicator(GameObject target, Camera mainCamera, Canvas canvas)
    {
        this.target = target;
        this.mainCamera = mainCamera;
        canvasRect = canvas.GetComponent<RectTransform>();
    }

    public void UpdateTargetIndicator()
    {
        SetIndicatorPosition();
    }

    protected void SetIndicatorPosition()
    {

        Vector3 indicatorPosition = mainCamera.WorldToScreenPoint(target.transform.position);

        if(indicatorPosition.z >= 0f & indicatorPosition.x <= canvasRect.rect.width * canvasRect.localScale.x & indicatorPosition.y <= canvasRect.rect.height * canvasRect.localScale.x & indicatorPosition.x >= 0f & indicatorPosition.y >= 0f)
        {
            indicatorPosition.z = 0f;
            targetOutOfSight(false, indicatorPosition);
        }
        else if (indicatorPosition.z >= 0f)
        {
            indicatorPosition = OutOfRangeIndicatorPositionB(indicatorPosition);
            targetOutOfSight(true, indicatorPosition);
        }
        else
        {
            indicatorPosition *= -1f;

            indicatorPosition = OutOfRangeIndicatorPositionB(indicatorPosition);
            targetOutOfSight(true, indicatorPosition);
        }

        rectTransform.position = indicatorPosition;
    }

    private Vector3 OutOfRangeIndicatorPositionB(Vector3 indicatorPosition)
    {
        indicatorPosition.z = 0f;

        Vector3 canvasCenter = new Vector3(canvasRect.rect.width / 2f, canvasRect.rect.height / 2f, 0f) * canvasRect.localScale.x;
        indicatorPosition -= canvasCenter;

        float divX = (canvasRect.rect.width / 2f - outOfSightOffset) / Mathf.Abs(indicatorPosition.x);
        float divY = (canvasRect.rect.height / 2f - outOfSightOffset) / Mathf.Abs(indicatorPosition.y);

        if(divX < divY)
        {
            float angle = Vector3.SignedAngle(Vector3.right, indicatorPosition, Vector3.forward);
            indicatorPosition.x = Mathf.Sign(indicatorPosition.x) * (canvasRect.rect.width * 0.5f - outOfSightOffset) * canvasRect.localScale.x;
            indicatorPosition.y = Mathf.Tan(Mathf.Deg2Rad * angle) * indicatorPosition.x;
        }
        else
        {
            float angle = Vector3.SignedAngle(Vector3.up, indicatorPosition, Vector3.forward);

            indicatorPosition.y = Mathf.Sign(indicatorPosition.y) * (canvasRect.rect.height / 2f - outOfSightOffset) * canvasRect.localScale.y;
            indicatorPosition.x = -Mathf.Tan(Mathf.Deg2Rad * angle) * indicatorPosition.y;
        }

        indicatorPosition += canvasCenter;
        return indicatorPosition;
    }

    private void targetOutOfSight(bool oos, Vector3 indicatorPosition)
    {
        if (oos)
        {
            if (offscreenTargetIndicator.gameObject.activeSelf == false) offscreenTargetIndicator.gameObject.SetActive(true);
            if (targetIndicatorImage.isActiveAndEnabled == true) targetIndicatorImage.enabled = false;

            offscreenTargetIndicator.rectTransform.rotation = Quaternion.Euler(RotationOutOfSightTargetIndicator(indicatorPosition));
        }
        else
        {
            if (offscreenTargetIndicator.gameObject.activeSelf == true) offscreenTargetIndicator.gameObject.SetActive(false);
            if (targetIndicatorImage.isActiveAndEnabled == false) targetIndicatorImage.enabled = true;
        
        }
    }
    private Vector3 RotationOutOfSightTargetIndicator(Vector3 indicatorPosition)
    {
        Vector3 canvasCenter = new Vector3(canvasRect.rect.width / 2f, canvasRect.rect.height / 2f, 0f) * canvasRect.localScale.x;

        float angle = Vector3.SignedAngle(Vector3.up, indicatorPosition - canvasCenter, Vector3.forward);

        return new Vector3(0f, 0f, angle);
    }
}
