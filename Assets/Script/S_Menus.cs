using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class S_Menus : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer startButton;
    [SerializeField]
    private SpriteRenderer optionsButton;
    [SerializeField]
    private float timeTodark;
    [SerializeField]
    private Slider musicSlider;
    [SerializeField]
    private GameObject options;
    [SerializeField]
    private GameObject credits;

    private void Start()
    {

        S_MusicSingleton.instance.MainMusic();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OpenOptions()
    {
        Debug.Log("Hey");
        optionsButton.color = Color.gray;
        StartCoroutine(nameof(ReturnToNormal));
        options.SetActive(true);

    } 
    public void OpenGame()
    {
        Debug.Log("Hoy");
        SceneManager.LoadScene("Sc_Doll");
    }
    public void HoldOptions()
    {
        optionsButton.color = Color.gray;
        StartCoroutine(nameof(ReturnToNormal));
       
    }
    public void HoldStart()
    {
        startButton.color = Color.gray;
        StartCoroutine(nameof(ReturnToNormal));
    }
    public IEnumerator ReturnToNormal()
    {
        yield return new WaitForSeconds(timeTodark);
        startButton.color = Color.white;
        optionsButton.color = Color.white; 
    }
    public void ChangeMusic()
    {
        //S_MusicSingleton.instance. sonido de ui si tenemos
        S_MusicSingleton.instance.MusicChange(musicSlider.value);
    }
   public void BacktoMenu()
    {
        options.SetActive(false);
        credits.SetActive(false);
    }
    public void OpenCredits()
    {
        credits.SetActive(true);
    }
}
