using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Helthbar : MonoBehaviour
{
    [SerializeField] private Health playerHealth;
    [SerializeField] private Image totalHealthbar;
    [SerializeField] private Image currentHealthbar;

    private void Start()
    {
        
    }

    private void Update()
    {
        currentHealthbar.fillAmount = playerHealth.currentHealth / 10;
    }
}
