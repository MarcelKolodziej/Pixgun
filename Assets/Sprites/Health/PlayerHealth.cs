using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float startingHealth;

    public float currentHealth { get; private set;} 

    private AnimationScript anim;

    private bool dead; 

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
            if(!dead)
            {
                anim.SetTrigger("die");
                //player dead
                GetComponent<PlayerMovement>().enabled = false;
                dead = true;
            }
        }
    }
   

   private void Update()
   {
    if(Input.GetKeyDown(KeyCode.E))
        TakeDamage(1);
   }

   public void AddHealth(float _value)
   {
        currentHealth = Mathf.Clamp(currentHealth + _value, 0, startingHealth);
   }

}
