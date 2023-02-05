using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_VeinSpeedCaper : MonoBehaviour
{
    private Rigidbody2D rigid;
    public static event System.Action<GameObject> killVein;
    void Start()
    {
        
    }
    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        if (rigid.velocity.x >= 500|| rigid.velocity.y >=500)
        {
            rigid.velocity = new Vector2(10,10);
        }
        if (this.gameObject.transform.position.x > 2000 || this.gameObject.transform.position.y > 2000)
        {
            
            Debug.Log("Killer vein");
            killVein(this.gameObject);
        }
    }
}
