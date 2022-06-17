using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyhealth : MonoBehaviour
{
    public Animator animator;
    
    public int maxhealth = 100;
    int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        animator.SetTrigger("hurt");

        if(currentHealth <= 0)
        {
            Die();
        }
        
    }
    void Die()
    {
        animator.SetBool("dead",true);
        Debug.Log("Enemy died");

        GetComponent<MeleeEnemy>().enabled = false;
        GetComponent<Collider2D>().enabled = false;
        GetComponentInParent<EnemyPatrol>().enabled = false;
        //EnemyPatrol.(false);
        this.enabled = false;
    }


}
