using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float health = 100f;
    public GameObject deathVFX;

    public void DealDamage(float damage)
    {
        health -= damage;

        if(health <= 0)
        {
            TriggerVFX();
            Destroy(gameObject, 0.1f);
        }
    }
    private void TriggerVFX()
    {
        if (!deathVFX)
        {
            return;
        }
        GameObject deathVFXobject = Instantiate(deathVFX, transform.position, transform.rotation);
        Destroy(deathVFXobject, 1f);
    }


}
