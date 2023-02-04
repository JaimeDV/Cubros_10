using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_Shake : MonoBehaviour
{
    [SerializeField]
    private float speed = 1.0f; //how fast it shakes
    [SerializeField]
    private float amount = 1.0f; //how much it shakes
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.position = transform.position+new Vector3(Mathf.Sin(Time.time * speed) * amount, 0,0);
        this.gameObject.transform.position = transform.position + new Vector3(0,Mathf.Sin(Time.time * speed) * amount, 0);

    }
}
