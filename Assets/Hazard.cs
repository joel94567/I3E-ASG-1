using UnityEngine;

public class Hazard : MonoBehaviour
{
    public enum HazardType
    {
        Fire,
        Poison,
        Spikes
    }

    public HazardType hazardType;

    public float damagePerSecond = 10f;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CollectibleManager.instance.TakeDamage(damagePerSecond * Time.deltaTime);
        }
    }
}