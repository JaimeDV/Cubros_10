using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_EggMove : MonoBehaviour
{

    private Rigidbody2D rigid;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }
    private void MoveEgg(GameObject egg)
    {
   
        if (this.gameObject.Equals(egg))
        {
            rigid.gravityScale = 0.5f;
        }
       
    }
    private void OnEnable()
    {
        S_DragableSprite.eggCrack += MoveEgg;
    }
    private void OnDisable()
    {
        S_DragableSprite.eggCrack -= MoveEgg;
    }
}
