using UnityEngine;

public class Collectible : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ScoreManager.instance.CollectItem();
            Destroy(gameObject);
        }
    }
}

    // Update is called once per frame

