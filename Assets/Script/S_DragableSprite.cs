using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class S_DragableSprite : MonoBehaviour
{
    private bool draged;
    private Transform focus;
    private Camera cam;
    private Vector2 position;
    private Vector2 offset;
    private RaycastHit hit;
    private Ray ray;
    private Rigidbody2D riggid;

    void Start()
    {
        draged = false;
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ray=cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray.origin,ray.direction,out hit))
            {
                focus = hit.collider.transform;
                position = cam.WorldToScreenPoint(focus.position);
                hit.get
            }
        }
    }
}
