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
        SceneManager.LoadScene("Sc_MainMenu");
    }
}
