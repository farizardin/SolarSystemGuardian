using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidGenerator : MonoBehaviour
{

    public GameObject[] asteroidLokasi;
    public GameObject asteroid;
    public float spinSpeed = 20;
    private Rigidbody rg;
    public Transform target;
    public float speed;

    void Start()
    {
        int x = Random.Range(0, asteroidLokasi.Length);
        Debug.Log(x);
        Vector3 tempat = new Vector3(asteroidLokasi[x].transform.position.x, asteroidLokasi[x].transform.position.y, asteroidLokasi[x].transform.position.z);
        gameObject.transform.position = tempat;

        asteroid.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.Rotate(Vector3.forward, spinSpeed * Time.deltaTime);
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }

    public void LocationTrigger(GameObject a, GameObject[] loc)
    {
        int x = Random.Range(0, loc.Length);
        Vector3 tempat = new Vector3(loc[x].transform.position.x,loc[x].transform.position.y, loc[x].transform.position.z);
        a.transform.position = tempat;

        a.SetActive(true);
    }
}