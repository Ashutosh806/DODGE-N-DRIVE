using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEffects : MonoBehaviour
{
    public int damageAmount = 0;
    public CarHealth carHealth;

    public GameObject hitEffectPrefab;

    void OnCollisionEnter(Collision other)
    {
       if(other.gameObject.CompareTag("Barrier"))
       {
         damageAmount = 5;
         Instantiate(hitEffectPrefab,other.GetContact(0).point,Quaternion.identity);
         carHealth.TakeDamage(damageAmount);
       }  

       if(other.gameObject.CompareTag("Tree"))
       {
         damageAmount = 100;
         Instantiate(hitEffectPrefab,other.GetContact(0).point,Quaternion.identity);
         carHealth.TakeDamage(damageAmount);
       }          
    }
}
