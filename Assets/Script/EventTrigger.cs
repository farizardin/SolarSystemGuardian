using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class EventTrigger : MonoBehaviour
{
    public GameObject asteroid;
    public GameObject[] asteroidLokasi;
    public TMPro.TextMeshProUGUI healt;
    public TMPro.TextMeshProUGUI score;
    public TMPro.TextMeshProUGUI endScore;
    private int hp = 3;
    private int point = 0;
    private int gameScore;
    public Canvas panel;
    //public Panel skorFinal;
    // Start is called before the first frame update
    void Start()
    {
        healt.GetComponent<TMPro.TextMeshProUGUI>().text = "3";
        score.GetComponent<TMPro.TextMeshProUGUI>().text = "0";
        //panel.gameObject.SetActive(false);
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        if (other.name == "Projectile")
        {
            point += 10;
            score.GetComponent<TMPro.TextMeshProUGUI>().text = point.ToString();
            AsteroidGenerator setLokasiBaru = new AsteroidGenerator();
            setLokasiBaru.LocationTrigger(asteroid, asteroidLokasi);
        }
        if (other.name == "Laser")
        {
            if(hp >0)
            {
                hp -= 1;
                Debug.Log(hp);
                healt.GetComponent<TMPro.TextMeshProUGUI>().text = hp.ToString();
                AsteroidGenerator setLokasiBaru = new AsteroidGenerator();
                setLokasiBaru.LocationTrigger(asteroid, asteroidLokasi);
            }
            else if (hp<1)
            {
                //panel.gameObject.SetActive(true);
                hp = 0;
                healt.GetComponent<TMPro.TextMeshProUGUI>().text = hp.ToString();
                //Time.timeScale = 0;
                gameScore = point;
                //endScore.GetComponent<TMPro.TextMeshProUGUI>().text = gameScore.ToString();
                //skorFinal.skorAkhir = gameScore;
                Panel.Skor(gameScore);
                CamTexture.OnCameraStop();
                SceneManager.LoadScene("GameOver");
            }
        }
    }

    void Update()
    {

    }
}
