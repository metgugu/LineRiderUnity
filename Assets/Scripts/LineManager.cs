using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LineManager : MonoBehaviour
{
    public static LineManager instance;  // �̱��� �������� LineManager�� ����
    public TextMeshPro totalDistanceText;  // �� �Ÿ��� ǥ���� TextMeshPro ��ü

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
            totalDistanceText.text = "�� ��ũ�� ��: " + totalDistance.ToString("F2") + "m";
        }
    }
}