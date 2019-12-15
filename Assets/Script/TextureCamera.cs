using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureCamera : MonoBehaviour
{
    // Start is called before the first frame update
    //public GameObject cameraDisplay;
    public Transform player;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Quaternion cameraRotation = new Quaternion(Input.gyro.attitude.x, Input.gyro.attitude.y, -Input.gyro.attitude.z, -Input.gyro.attitude.w);
        //this.transform.localRotation = cameraRotation;
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bullet = Instantiate(Resources.Load("Projectile", typeof(GameObject))) as GameObject;
            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            bullet.transform.rotation = player.transform.rotation;
            bullet.transform.position = player.transform.position;
            rb.AddForce(player.transform.forward * 250f);
            Destroy(bullet, 40);
        }
    }
}
