using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class S_DraggableVein : MonoBehaviour
{
    private bool draged;
    private Camera cam;
    public static event System.Action<GameObject> veinMove;
    void Start()
    {
        draged = false;
        cam = Camera.main;
    }
    public void OnMouseDown()
    {
       
        S_MusicSingleton.instance.BloodSound();
        draged = true;

    }
    public void OnMouseUp()
    {
        draged = false;
    }

    void Update()
    {
        if (draged)
        {
            veinMove(this.gameObject);
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);
        }
        

    }
    public static bool IsPointerOverGameObject()
    {
        //check mouse
        if (EventSystem.current.IsPointerOverGameObject())
            return true;

        //check touch
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            if (EventSystem.current.IsPointerOverGameObject(Input.touches[0].fingerId))
                return true;
        }

        return false;
    }
}
