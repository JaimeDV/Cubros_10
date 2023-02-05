using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="NewDoll",menuName ="Utilities/DollFile")]
public class So_Doll : ScriptableObject
{
    [SerializeField]
    public Sprite dollNoEye;
    [SerializeField]
    public Sprite dollEye;
    [SerializeField]
    public bool Eye;
    [SerializeField]
    public Sprite dollFetus;
    [SerializeField]
    public bool Fetus;
    [SerializeField]
    public Sprite dollAll;
}
