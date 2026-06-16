using UnityEngine;
using TMPro;

public class DoorInteract : MonoBehaviour
{
    public Animator doorAnimator;
    public TextMeshProUGUI doorMessage;

    private bool isOpen = false;

    public void TryOpen()
    {
        // Door is locked
        if (CollectibleManager.instance.collectiblesLeft > 0)
        {
            doorMessage.gameObject.SetActive(true);

            CancelInvoke(nameof(HideMessage));
            Invoke(nameof(HideMessage), 2f);

            Debug.Log("Collect all collectibles first.");
            return;
        }

        // Door unlocked
        doorMessage.gameObject.SetActive(false);

        isOpen = !isOpen;
        doorAnimator.SetBool("IsOpen", isOpen);
    }

    private void HideMessage()
    {
        doorMessage.gameObject.SetActive(false);
    }
}