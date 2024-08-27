using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaPlayer : MonoBehaviour
{
    int Life;
    public SpriteRenderer Vida1;
    public SpriteRenderer Vida2;
    public SpriteRenderer Vida3;
    public SpriteRenderer Vida4;
    // Start is called before the first frame update
    void Start()
    {
        Life = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if(Life == 0)
        {
            Vida1.enabled = false;
            Vida2.enabled = false;
            Vida3.enabled = false;
            Vida4.enabled = true;
            Destroy(gameObject);
        }
        if (Life == 1)
        {
            Vida1.enabled = false;
            Vida2.enabled = false;
            Vida3.enabled = true;
            Vida4.enabled = false;
            
        }
        if (Life == 2)
        {
            Vida1.enabled = false;
            Vida2.enabled = true;
            Vida3.enabled = false;
            Vida4.enabled = false;
            
        }
        if (Life == 3)
        {
            Vida1.enabled = true;
            Vida2.enabled = false;
            Vida3.enabled = false;
            Vida4.enabled = false;
            
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Enemy"))
        {
            Life = Life - 1;
            
        }
    }
}
