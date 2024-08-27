using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroComParticula : MonoBehaviour
{
    public ParticleSystem particleSystem;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.C))
        {
            Fire();
        }
    }
    void Fire()
    {
        particleSystem.Emit(1);
    }
}
