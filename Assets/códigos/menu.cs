using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void StartGame2()
    {
        SceneManager.LoadScene("finalBoss");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("menu");
    }



    public void ControlsMenu()
    {
        SceneManager.LoadScene("controles");
    }


    public void StartGame()
    {
        SceneManager.LoadScene("jogo");
    }




    public void QuitGame()
    {
        //UnityEditor.EditorApplication.isPlaying = false;

        Application.Quit();
    }


}


