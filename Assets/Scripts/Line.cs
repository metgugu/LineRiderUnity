using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Line : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public EdgeCollider2D edgeCollider;

    private List<Vector2> points;
    private float totalDistance;

    public void UpdateLine(Vector2 mousePos)
    {
        if (points == null)
        {
            points = new List<Vector2>();
            totalDistance = 0;
            SetPoint(mousePos);
            return;
        }

        if (Vector2.Distance(points.Last(), mousePos) > 0.1f)
        {
            SetPoint(mousePos);
        }
    }

    private void SetPoint(Vector2 point)
    {
        if (points.Count > 0)
        {
            float distance = Vector2.Distance(points.Last(), point);
            totalDistance += distance;  // 라인의 길이 업데이트
            LineManager.instance.AddDistance(distance);  // 총 거리 업데이트
        }

        points.Add(point);

        lineRenderer.positionCount = points.Count;
        lineRenderer.SetPosition(points.Count - 1, point);

        if (points.Count > 1)
        {
            edgeCollider.points = points.ToArray();
        }
    }
}
