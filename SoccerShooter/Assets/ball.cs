using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    // Start is called before the first frame update

 public float moveSpeed = 10;

 public GameObject bulletPrefab;

 public int Score = 0;


    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
         
    transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed);
        if (Input.GetButtonDown("Fire1")){
            GameObject bullet = Instantiate(bulletPrefab,transform.position, transform.rotation);
            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            rb.velocity = Vector3.forward * 300;
            Destroy(bullet, 4);
        }
         

    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(Score = +1);
    }
}
