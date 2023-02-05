using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class S_VeinRemover : MonoBehaviour //todos los scripts de eggs y vein deberian juntarse en uno solo
{
    private string eggTag = "Egg";
    [SerializeField]
    private float maxTendrils;
    private static int shells = 0;
    [SerializeField]
    private float fetusTime = 1f;
    [SerializeField]
    private So_Doll doll;
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("hey");
        if (other.tag.Equals(eggTag))
        {
            shells++;
            Debug.Log("Shell"+shells);
            Destroy(other.gameObject);
        }
    }
    private void Update()
    {
        if (shells >= maxTendrils)
        {
            StartCoroutine(nameof(EndEgg));
        }
    }
    private IEnumerator EndEgg()
    {
        //aqui algo de auido
        yield return new WaitForSeconds(fetusTime);
        doll.Eye = true;
        S_MusicSingleton.instance.MainMusic();
        S_MusicSingleton.instance.StopEye();
        SceneManager.LoadScene("Sc_Doll");

    }
    private void VeinKiller(GameObject other)
    {
        shells++;
        Debug.Log("Shell" + shells);
        Destroy(other.gameObject);
    }
    private void OnEnable()
    {
        S_VeinSpeedCaper.killVein += VeinKiller;
    }
    private void OnDisable()
    {
        S_VeinSpeedCaper.killVein -= VeinKiller;
    }
}
