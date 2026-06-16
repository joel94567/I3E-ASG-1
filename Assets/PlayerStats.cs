using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public float health = 100f;

    public void TakeDamage(float amount)
    {
        health -= amount;
        Debug.Log("Health: " + health);

        if (health <= 0)
        {
            Debug.Log("Player died.");
        }
    }
}
