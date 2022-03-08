using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    [SerializeField] float objectHealth = 100f;
    
    public void TakeDamage(float damage)
    {
        //like writing 'objectHealth -= damage' but ensures objectHealth doesn't go below 0
        objectHealth = Mathf.Max(objectHealth - damage, 0);
        print(objectHealth);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
