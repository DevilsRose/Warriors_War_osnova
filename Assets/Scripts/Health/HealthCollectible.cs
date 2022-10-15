using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
    [SerializeField] private float helthValue;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            collision.GetComponent<Health>().AddHealth(helthValue);
            gameObject.SetActive(false);
        }
    }
}
