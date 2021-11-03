using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject Lvls;
    public GameObject buttonsMainMenu;
    public GameObject verisonText;
    public GameObject titleGame;
    public GameObject credits;
    public GameObject options;


    public GameObject musicBar;

    public static MenuController instanceMenu;

    // Start is called before the first frame update
    void Start()
    {
        instanceMenu = this;
        Destroy(GameObject.Find("Music Player"));
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(PlayerPrefs.GetFloat("musicBar"));
    }

    public void LoadScene(string lvlName)
    {
        SceneManager.LoadScene(lvlName);
    }

    public void ShowLvls()
    {
        MainMenu.SetActive(false);
        Lvls.SetActive(true);
    }

    public void BackLvls()
    {
        Lvls.SetActive(false);
        MainMenu.SetActive(true);
    }

    public void ShowOptions()
    {
        MainMenu.SetActive(false);
        musicBar.GetComponent<Slider>().value = PlayerPrefs.GetFloat("musicBar");
        options.SetActive(true);
    }

    public void BackOptions()
    {
        options.SetActive(false);
        PlayerPrefs.SetFloat("musicBar", musicBar.GetComponent<Slider>().value);
        MainMenu.SetActive(true);
    }

    public void ShowCredits()
    {
        buttonsMainMenu.SetActive(false);
        titleGame.SetActive(false);
        verisonText.SetActive(false);
        credits.SetActive(true);
    }

    public void BackCredits()
    {
        credits.SetActive(false);
        buttonsMainMenu.SetActive(true);
        titleGame.SetActive(true);
        verisonText.SetActive(true);
    }
}
