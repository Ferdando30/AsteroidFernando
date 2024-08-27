using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentaçao : MonoBehaviour
{
    public Rigidbody2D rdb;
    public float velocidade;
    public SpriteRenderer fogo;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, -3.3f, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    private void FixedUpdate()
    {
        
        if (Input.GetKey(KeyCode.D))
        {
            rdb.AddTorque(-3);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rdb.AddTorque(3);
        }
        if (Input.GetKey(KeyCode.W))
        {
            rdb.AddRelativeForce(Vector2.up * velocidade);
            fogo.enabled = true;
            
        }
        else
        {
            fogo.enabled = false;
        }
        
    }
}
