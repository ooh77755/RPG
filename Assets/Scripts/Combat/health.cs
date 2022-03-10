using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float objectHealth = 100f;

    bool isDead = false;
    
    public void TakeDamage(float damage)
    {
        //like writing 'objectHealth -= damage' but ensures objectHealth doesn't go below 0
        objectHealth = Mathf.Max(objectHealth - damage, 0);

        if (objectHealth == 0 && !isDead)
        {
            Die();
        }
    }

    private void Die()
    {
        GetComponent<Animator>().SetTrigger("isDying");
        isDead = true;
    }
}
