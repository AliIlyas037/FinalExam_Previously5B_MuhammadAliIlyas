using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Handleinpenguscenemenu : MonoBehaviour
{
    public GameObject gotomainmenu;
    public void menubutton()
    {
        gotomainmenu.SetActive(true);
    }
    public void Continuebutton()
    {
        gotomainmenu.SetActive(false);

    }
    public void PnaelMenubutton()
    {
        SceneManager.LoadScene("Main Menu");
    }
    
}
