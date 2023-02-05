using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class S_ShellHitter : MonoBehaviour
{
    private string eggTag = "Egg";
    private int shells = 0;
    [SerializeField]
    private float fetusTime=1f;
    [SerializeField]
    private So_Doll doll;
    private void Start()
    {
        S_MusicSingleton.instance.EggMusic();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals(eggTag))
        {
            shells++;
            Destroy(other.gameObject);  
        }
    }
    private void Update()
    {
        if (shells >= 7)
        {
            StartCoroutine(nameof(EndEgg));
        }
    }
    private IEnumerator EndEgg()
    {
        //aqui algo de auido
        yield return new WaitForSeconds(fetusTime);
        doll.Fetus = true;
        S_MusicSingleton.instance.MainMusic();
        SceneManager.LoadScene("Sc_Doll");
    }
}
