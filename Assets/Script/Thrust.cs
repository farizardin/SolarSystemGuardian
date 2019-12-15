using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thrust : MonoBehaviour
{
    public float minSpinSpeed = 5f;
    public float maxSpinSpeed = 20;
    private float spinSpeed;
    private Rigidbody rg;
    public Transform target;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.Rotate(Vector3.forward, spinSpeed * Time.deltaTime);
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }
}
