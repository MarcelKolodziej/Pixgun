using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float startingHealth;

    public float currentHealth { get; private set;} 

    private AnimationScript anim;

    private void Awake()
    {
        currentHealth = startingHealth;
        anim = GetComponentInChildren<AnimationScript>();
    }

    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);

        if (currentHealth > 0)
        {
            //player hurt
            anim.SetTrigger("hurt");

        }
        else 
        {
            anim.SetTrigger("die");
            //player dead
        }
    }
   

   private void Update()
   {
    if(Input.GetKeyDown(KeyCode.E))
        TakeDamage(1);
   }
}
