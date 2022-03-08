using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class DrawLine : MonoBehaviour
{

    public Transform startingPoint;
    public Transform targetLocation;

    public LineRenderer lineRenderer;
    public NavMeshPath path;

    float elapsed;

    void Start()
    {
        path = new NavMeshPath();
        elapsed = 0.0f;

        this.targetLocation = 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
