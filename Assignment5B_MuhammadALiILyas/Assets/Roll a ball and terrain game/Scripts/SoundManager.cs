using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour
{

    //sounds used in game
    public AudioSource clickSound;
   
    // Use this for initialization

    //play sound if ball collide with cube
    public void PlaySound(AudioSource sound)
    {
       // if (PlayerPrefs.GetInt("sound", 1) == 1)
         //{
            sound.Play();
        //}
    }


}
