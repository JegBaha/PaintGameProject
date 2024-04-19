using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void playSceneButton()
    {
        SceneManager.LoadScene(0);
    }

    public void quitSceneButton()
    {
        Application.Quit();
    }
    
}
