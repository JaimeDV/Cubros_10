using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class S_DollMenu : MonoBehaviour
{
    [SerializeField]
    private So_Doll doll;
    [SerializeField]
    private Image dollImage;
    [SerializeField]
    private Button eyeButton;
    [SerializeField]
    private Button fetusButton;
    void Start()
    {
        //S_MusicSingleton.instance.MainMusic();
        if (doll.Eye == true)
        {
            dollImage.sprite = doll.dollEye;
        }
        if (doll.Fetus == true)
        {
            dollImage.sprite = doll.dollFetus;
        }
        if (doll.Eye == true&& (doll.Fetus==true))
        {
            dollImage.sprite = doll.dollAll;
        }
    }

    public void OpenEye()
    {
        SceneManager.LoadScene("Sc_Eye");
    }
    public void OpenEgg()
    {
        SceneManager.LoadScene("Sc_Egg");
    }
}
