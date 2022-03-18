using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goal : MonoBehaviour
{
  
    
    private void OnTriggerEnter(Collider other)
    {
        GameData.Score = GameData.Score +1;
        Destroy(gameObject);
        
    }
   
}
