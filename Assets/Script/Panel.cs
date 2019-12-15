using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Panel : MonoBehaviour
{
    public TMPro.TextMeshProUGUI endScore;
    public static int skorAkhir;
    public Button sT;
    public Button eT;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        endScore.GetComponent<TMPro.TextMeshProUGUI>().text = skorAkhir.ToString();
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void StartLevel()
    {
        SceneManager.LoadScene("Game");
    }

    public static void Skor(int skor)
    {
        skorAkhir = skor;
    }
}
