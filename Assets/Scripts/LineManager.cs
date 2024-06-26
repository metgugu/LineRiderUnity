using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LineManager : MonoBehaviour
{
    public static LineManager instance;  // ½Ì±ÛÅæ ÆÐÅÏÀ¸·Î LineManager¸¦ °ü¸®
    public TextMeshPro totalDistanceText;  // ÃÑ °Å¸®¸¦ Ç¥½ÃÇÒ TextMeshPro °´Ã¼

    private float totalDistance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddDistance(float distance)
    {
        totalDistance += distance;
        UpdateTotalDistanceText();
    }

    public void ResetTotalDistance()
    {
        totalDistance = 0;
        UpdateTotalDistanceText();
    }

    private void UpdateTotalDistanceText()
    {
        if (totalDistanceText != null)
        {
            totalDistanceText.text = "¾´ À×Å©ÀÇ ¾ç: " + totalDistance.ToString("F2") + "m";
        }
    }
}