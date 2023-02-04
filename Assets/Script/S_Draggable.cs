using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class S_Draggable : MonoBehaviour, IPointerDownHandler,IBeginDragHandler,IEndDragHandler,IDragHandler {
    [SerializeField]
    private Canvas canvas;
    private CanvasGroup canvasGroup;
    private RectTransform position;
    [SerializeField]
    private float dragFactor=1;
    [SerializeField]
    private float limitVelocity = 1.5f;

    private void Awake()
    {
        position = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Start Dragging");
        //canvasGroup.blocksRaycasts = false;
        //canvasGroup.alpha = 0.6f;
    }

    public void OnDrag(PointerEventData eventData)//mientras haces drag
    {
        Vector2 velocity = (eventData.delta / canvas.scaleFactor) * dragFactor;
        if (velocity.x> limitVelocity)
        {
            velocity.x = limitVelocity;
        }
        if (velocity.y > limitVelocity)
        {
            velocity.y = limitVelocity;
        }
        if (velocity.x < -limitVelocity)
        {
            velocity.x = -limitVelocity;
        }
        if (velocity.y < -limitVelocity)
        {
            velocity.y = -limitVelocity;
        }
        position.anchoredPosition += velocity;
        Debug.Log(velocity);

    }

    public void OnEndDrag(PointerEventData eventData)//al acabar
    {
        Debug.Log("Not holding");
        canvasGroup.blocksRaycasts = true;
        canvasGroup.alpha = 1f;
    }

    public void OnPointerDown(PointerEventData eventData)//
    {
        Debug.Log("Holding");
    }

}
