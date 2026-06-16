using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public float interactDistance = 3f;
    public AudioClip interactSFX;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Collider[] hits = Physics.OverlapSphere(transform.position, interactDistance);

            foreach (Collider hit in hits)
            {
                Collectible collectible = hit.GetComponent<Collectible>();

                if (collectible != null)
                {
                    collectible.Collect();
                    PlaySFX();
                    return;
                }

                DoorInteract door = hit.GetComponent<DoorInteract>();

                if (door != null)
                {
                    door.TryOpen();
                    PlaySFX();
                    return;
                }
            }
        }
    }

    private void PlaySFX()
    {
        if (interactSFX != null)
        {
            AudioSource.PlayClipAtPoint(interactSFX, transform.position);
        }
    }
}