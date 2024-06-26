using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LineCreator : MonoBehaviour
{
    public GameObject Flag;
    public GameObject linePrefab;
    private Line activeLine;

    void Update()
    {
        if (Flag.GetComponent<Flag>().isCleared == false)
        {
            if (Input.GetMouseButtonDown(0))
            {
                GameObject lineGO = Instantiate(linePrefab);
                activeLine = lineGO.GetComponent<Line>();
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            activeLine = null;
        }

        if (activeLine != null)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            activeLine.UpdateLine(mousePos);
        }
    }
}