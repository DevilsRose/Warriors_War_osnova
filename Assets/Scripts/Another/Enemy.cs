﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Animator animator;
    
    public int maxHealth = 100;
    int currentHealth;
    
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        animator.SetTrigger("hurt");

        //play hurt animations
        if(currentHealth <= 0)
        {
            Die();
        }

        void Die()
        {
            //die animations
            animator.SetBool("isDead", true);

            //disable the enemy
            Object.Destroy(gameObject,2f);

        }
    }
}