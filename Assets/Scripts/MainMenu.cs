using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Light()
    {
        print("Light");
        SceneManager.LoadScene(1);
    }

    public void Image()
    {
        SceneManager.LoadScene(2);
        print("Image");
    }

    public void Quit()
    {
        print("Quit");
        Application.Quit();
    }
 
}
