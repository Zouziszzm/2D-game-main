using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Animator animator;
    public Transform attackpoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;

    public int attackDamage = 100;
    public float attackRate = 2f;

    float nextAttackTime = 0f;
    // Update is called once per frame
    void Update()
    {
        if(Time.time >= nextAttackTime)
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                Attack();
                nextAttackTime = Time.time + 1f / attackRate;
            }
        }
    }
    void Attack()
    {
        animator.SetTrigger("Attack");



        Collider2D[] hitenemies = Physics2D.OverlapCircleAll(attackpoint.position, attackRange, enemyLayers);
        
        
        foreach(Collider2D enemy in hitenemies)
        {
            Debug.Log("we hit" + enemy.name);
            enemy.GetComponent<Enemyhealth>().TakeDamage(attackDamage);
        }
    }
    private void OnDrawGizmosSelected()
    {
        if (attackpoint == null)
            return;
        Gizmos.DrawSphere(attackpoint.position, attackRange);
    }
}
