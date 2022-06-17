using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    public float currentHelath { get; private set; }
    private Animator anim;
    private Animation ani;
    private bool dead;

    public GameObject gameoverPanel;
    private void Awake()
    {
        currentHelath = startingHealth;
        anim = GetComponent<Animator>();
        ani = GetComponent<Animation>();

    }
    public void TakeDamage(float _damage)
    {
        currentHelath = Mathf.Clamp(currentHelath - _damage, 0, startingHealth);
 
        if(currentHelath >0)
        {
            //player hurt
            anim.SetTrigger("hurt");
        }
        else
        {
            if (!dead)
            {
                //player dead
                anim.SetTrigger("die");
                GetComponent<PlayerMovement>().enabled = false;
                dead = true;
                GetComponent<Collider2D>().enabled = false;
                gameoverPanel.SetActive(true);
                /// GameObject[]
                //gameObject.SetActive(false);
                //               e1 = GameObject.FindGameObjectsWithTag("Player");
                //for(int i=0;1< e1.Length;i++)
                // {
                //    e1[i].SetActive(false);
                //}
            }
            
        }
    }

    public void AddHealth(float _value)
    {
        currentHelath = Mathf.Clamp(currentHelath + _value, 0, startingHealth);
    }
}
//31:15