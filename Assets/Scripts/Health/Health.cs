using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    public float currentHealth { get; private set; }
    private Animator anim;
    private bool dead;

    private void Awake()
    {
        currentHealth = startingHealth;
        anim = GetComponent<Animator>();
    }

    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);

       if(currentHealth > 0)
        {
            //player hurt
            anim.SetTrigger("hurt");

        }
        else
        {
            if(!dead)
            {
                //player dead
                anim.SetTrigger("die");
                if(GetComponent<PlayerMovement>() != null)
                    GetComponent<PlayerMovement>().enabled = false;

                //enemy dead
                if(GetComponentInParent<EnemyPatrol>() != null)
                    GetComponentInParent<EnemyPatrol>().enabled = false;
                
                if(GetComponent<MeleeEnemy>() != null)
                    GetComponent<MeleeEnemy>().enabled = false;
                
                dead = true;
            }
           
        }

    }

    public void AddHealth(float _value)
    {
        currentHealth = Mathf.Clamp(currentHealth + _value, 0, startingHealth);
    }

}
