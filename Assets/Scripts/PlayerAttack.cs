using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private float attackCooldown;
    private AnimationScript anim;
    private PlayerMovement playerMovement;
    private float coolDownTimer = Mathf.Infinity;

    
    private void Awake()
    {
        anim = GetComponentInChildren<AnimationScript>();
        playerMovement = GetComponent<PlayerMovement>();
    }


    private void Update()
    {

        if (Input.GetMouseButton(1) && coolDownTimer > attackCooldown && playerMovement.canAttack())
        Attack();

        coolDownTimer += Time.deltaTime;
    }

    private void Attack()
    {
        Debug.Log("attack Player Attack");
        anim.SetTrigger("attack");
        coolDownTimer = 0;
    }

}
