using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    
    private void OnParticleCollision(GameObject other)
    {
        
        
            Destroy(gameObject);
        
    }
}
