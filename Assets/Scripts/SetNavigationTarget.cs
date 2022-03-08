using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class SetNavigationTarget : MonoBehaviour
{
    [SerializeField] private Camera topDownCamera;
    [SerializeField] private GameObject navTargetObject;

    private NavMeshPath path; //current calculated path
    private LineRenderer line; //linerenderer to display path

    private bool lineToggle = false;


    // Start is called before the first frame update
    private void Start()
    {
        path = new NavMeshPath();
        line = transform.GetComponent<LineRenderer>();

        line.useWorldSpace = true;

       
        /**
        line.startWidth = 0.3f;
        line.endWidth = 0.3f;
        line.positionCount = 0;
        **/
    }

    // Update is called once per frame
    private void Update()
    {
        
        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
        {
            lineToggle = !lineToggle;
        }

        if (lineToggle)
        {
            NavMesh.CalculatePath(transform.position, navTargetObject.transform.position, NavMesh.AllAreas, path);
            line.positionCount = path.corners.Length;
            line.SetPositions(path.corners);
            line.enabled = true;
        }


    }

}
