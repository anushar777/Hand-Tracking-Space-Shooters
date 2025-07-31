using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LineCode : MonoBehaviour
{

    LineRenderer lineRenderer;
    public Transform begin;
    public Transform end;
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.startWidth = 0.1f;
        lineRenderer.endWidth = 0.1f;

    }

    void Update()
    {
        lineRenderer.SetPosition(0, begin.position);
        lineRenderer.SetPosition(1, end.position);
    }
}
