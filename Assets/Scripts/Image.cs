using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Image : MonoBehaviour
{
    public GameObject ui;

    void Start()
    {
        ui.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        print("escape");
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Toggle();
        }
    }

    void Toggle()
    {
        ui.SetActive(!ui.activeSelf);

        if (ui.activeSelf)
            Time.timeScale = 0f;
        else
            Time.timeScale = 1f;
    }

    public void Continue()
    {
        print("Continu");
        Toggle();
    }

    public void Menu()
    {
        print("Menu");
        SceneManager.LoadScene(0);
    }

    public void Quit()
    {
        print("Quit");
        Application.Quit();
    }
}
