using UnityEngine;

public class Collectible : MonoBehaviour
{
    public int scoreValue = 10;

    public AudioClip collectSFX;

    public void Collect()
    {
        CollectibleManager.instance.CollectItem(scoreValue);

        if (collectSFX != null)
        {
            AudioSource.PlayClipAtPoint(collectSFX, transform.position);
        }

        Destroy(gameObject);
    }
}
    // Update is called once per frame

