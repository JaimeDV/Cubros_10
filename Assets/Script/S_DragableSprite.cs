using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class S_DragableSprite : MonoBehaviour
{
    private bool draged;
    private Camera cam;
    public static event System.Action<GameObject> eggCrack;
    void Start()
    {
        draged = false;
        cam = Camera.main;
    }
    public void OnMouseDown()
    {
        draged = true;
    }
    public void OnMouseUp()
    {
        draged= false;
    }

    void Update()
    {
        if (draged)
        {
            eggCrack(this.gameObject);
           
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);
        }
    }
       
}
