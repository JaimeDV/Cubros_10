using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class S_MusicSingleton : MonoBehaviour
{
    public static S_MusicSingleton instance { get; private set; }
    [SerializeField]
    private AudioSource music;
    [SerializeField]
    private AudioSource soundEffects;
    [SerializeField]
    private AudioSource SecondarySoundEffects;
    [SerializeField]
    private AudioClip eggSmash1;
    [SerializeField]
    private AudioClip eggSmash2;
    [SerializeField]
    private AudioClip blood1;
    [SerializeField]
    private AudioClip blood2;
    [SerializeField]
    private AudioClip blood3;
    private float rangeMaxPitch = 1.1f;
    private float rangeMinPitch = 0.8f;
    private void Awake()
    {
     if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    private void Start()
    {
        music.loop = true;
    }


    // Update is called once per frame
    public void Eggcrack()
    {
        float randomNumber = Random.Range(0, 10);
        if (randomNumber <= 5)
        {
            soundEffects.clip=eggSmash1;
        }
        else
        {
            soundEffects.clip = eggSmash2;
        }
        soundEffects.pitch = Random.Range(rangeMinPitch, rangeMaxPitch);
        soundEffects.Play();
    }
    public void BloodSound()
    {
        float randomNumber = Random.Range(0, 10);
        if (randomNumber <= 3)
        {
            soundEffects.clip = blood1;
        }
        else if (randomNumber < 7)
        {
            soundEffects.clip = blood2;
        }
        else
        {
            soundEffects.clip = blood3;
        }
        soundEffects.pitch = Random.Range(rangeMinPitch, rangeMaxPitch);
        soundEffects.Play();
    }
}
