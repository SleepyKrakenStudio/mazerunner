using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
   int _hits = 0;
   private void OnCollisionEnter(Collision other) 
   {
       if(!other.gameObject.CompareTag("Hit"))
       {
            _hits++;
            Debug.Log("You've bumped into something this amount of times: " + _hits);
            other.gameObject.tag = "Hit";
       }
    
   }
}
