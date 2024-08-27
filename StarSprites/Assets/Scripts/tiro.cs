using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiro : MonoBehaviour
{
    public GameObject bulletPreFeb;
    public Transform FirePoint;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C)) 
        {
            Fire();
        }        
    }
    void Fire()
    {
        GameObject bullet = Instantiate(bulletPreFeb, FirePoint.position, FirePoint.rotation);
        bullet.GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.up * 10, ForceMode2D.Impulse);
    }
}
