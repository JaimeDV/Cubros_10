using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_VeinMove : MonoBehaviour
{
    private Rigidbody2D rigid;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }
    private void MoveVein(GameObject vein)
    {
        if (this.gameObject.Equals(vein))
        {
            rigid.gravityScale = 3f;
        }

    }
    private void OnEnable()
    {
        S_DraggableVein.veinMove += MoveVein;
    }
    private void OnDisable()
    {
        S_DraggableVein.veinMove -= MoveVein;
    }
}
