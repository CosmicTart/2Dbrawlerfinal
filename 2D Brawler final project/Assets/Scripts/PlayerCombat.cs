using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    //public Animator animator;

    //attack parameters
    public Transform attackPoint;
    public float attackRange = 0.9f;
    public LayerMask enemyLayers;
    public int atkDamage = 20;

    private float timeBtwAttack;
    public float startTimeBtwAttack;





    void Update()
    {
        if(timeBtwAttack <= 0)
            { 
            if (Input.GetButton("Fire1"))
            {
                Attack();
            }
            timeBtwAttack = startTimeBtwAttack;
        }
        else
        {
            timeBtwAttack -= Time.deltaTime;
        }

    }


    void Attack()
    {
        //play attack animation
        // animator.SetTrigger("Attack")
        // maybe need more than one attack

        //detect enemies
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);


        //damage them
        foreach (Collider2D enemy in hitEnemies)
        {
            Debug.Log("We hit " + enemy.name);
            enemy.GetComponent<Enemies>().TakeDamage(atkDamage);
        }

    }
    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }

}
