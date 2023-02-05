using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class S_MoveEye : MonoBehaviour
{

    private Rigidbody2D rigid;
    [SerializeField]
    public float factor = 0.25f;
    [SerializeField]
    private float speed = 1.0f; //how fast it shakes
    [SerializeField]
    private float amount = 1.0f; //how much it shakes
    public float limit = 0.08f;
    private Vector3 center;
    void Start()
    {
        S_MusicSingleton.instance.EyeMusic();
        S_MusicSingleton.instance.SecondaryEye();
        rigid = GetComponent<Rigidbody2D>();
        center = transform.position;
    }
    void Update()
    {

        //Convert mouse pointer cords into a worldspace vector3
        Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition + new Vector3(Mathf.Sin(Time.time * speed) * amount, Mathf.Sin(Time.time * speed) * amount, 0));

        pos.z = 0.0f;

        //Create a dir target based on mouse vector * factor
        Vector3 dir = pos * factor;

        //Clamp the dir target
        dir = Vector3.ClampMagnitude(dir, limit);

        //Update the pupil position
        transform.position = center + dir;
    }
}
