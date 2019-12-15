using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public Button sT;
    public Button eT;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void StartLevel()
    {
        SceneManager.LoadScene("Game");
    }
}
