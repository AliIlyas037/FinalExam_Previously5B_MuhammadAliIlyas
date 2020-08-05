using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HandlingMainMenu : MonoBehaviour
{
    public GameObject panelofmainmenu;
    public GameObject panelofmlagents;
    public GameObject panelofhummingbird;
    public GameObject panelofcomputational;
    public GameObject panelofpalindrome;
    public GameObject panelofparenthesis;
    public GameObject panelforpalindromelan;
    public GameObject panelforparenthesislan;
    public GameObject panelofcourse;

    public string url;
   // public Button quitButton;

    // Start is called before the first frame update
    void Start()
    {
        panelofmainmenu.SetActive(true);
        //quitButton = GetComponent<Button>();
        //quitButton.OnClick.AddListener(Quit);
    }
    public void mainmenu()
    {
        panelofcomputational.SetActive(true);
        panelofmainmenu.SetActive(false);
    }
    public void Mlagent()
    {
        panelofcomputational.SetActive(false);
        panelofmlagents.SetActive(true);

    }
    public void Penguingame()
    {
        SceneManager.LoadScene("Penguins");
    }
    //public void Hummingbirdmenu()
    //{
    //    panelofhummingbird.SetActive(true);
    //    panelofmlagents.SetActive(false);
    //}
    //public void Mlagenttraining()
    //{
    //    SceneManager.LoadScene("Training");
    //}
    public void Battlewithmlagent()
    {
        SceneManager.LoadScene("FlowerIsland");
    }
    public void backfrommlagent()
    {
        panelofcomputational.SetActive(true);
        panelofmlagents.SetActive(false);
    }
    //public void back()
    //{
    //    panelofmlagents.SetActive(true);
    //    panelofhummingbird.SetActive(false);
    //}
    public void Computationalmethod()
    {
        panelofmainmenu.SetActive(false);
        panelofcomputational.SetActive(true);
    }
    public void palindrome()
    {
        panelofcomputational.SetActive(false);
        panelofpalindrome.SetActive(true);
    }
    public void palindromelanguage()
    {
        panelofpalindrome.SetActive(false);
        panelforpalindromelan.SetActive(true);
    }
    public void returnpalindrome()
    {
        panelofpalindrome.SetActive(true);
        panelforpalindromelan.SetActive(false);
    }
    public void Parenthesis()
    {
        panelofcomputational.SetActive(false);
        panelofparenthesis.SetActive(true);
    }
    public void Parenthesislanguage()
    {
        panelofparenthesis.SetActive(false);
        panelforparenthesislan.SetActive(true);
    }
    public void returnParenthesis()
    {
        panelofparenthesis.SetActive(true);
        panelforparenthesislan.SetActive(false);
    }
    public void returnmainmenu()
    {
        panelofparenthesis.SetActive(false);
        panelofmainmenu.SetActive(false);
        panelofpalindrome.SetActive(false);
        panelofcomputational.SetActive(true);
    }
    public void returnfromcompute()
    {
        panelofparenthesis.SetActive(false);
        panelofmainmenu.SetActive(true);
        panelofpalindrome.SetActive(false);
        panelofcomputational.SetActive(false);
    }
    public void course()
    {
        panelofmainmenu.SetActive(false);
        panelofcourse.SetActive(true);

    }
    public void backcourse()
    {
        panelofmainmenu.SetActive(true);
        panelofcourse.SetActive(false);
    }
    public void ballgamepalindrome()
    {
        SceneManager.LoadScene("Roll a ball game");

    }
    public void Open()
    {
        Application.OpenURL(url);
    }
    public void Quit()
    {
        Debug.Log("game quit");
        Application.Quit();
        Application.OpenURL("about:blank");
    }

    public void Terraingame()
    {
        SceneManager.LoadScene("Terrain Ball");
    }
}
