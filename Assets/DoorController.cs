using UnityEngine;

public class DoorController : MonoBehaviour
{
    public GameObject door; // Reference to the door game object
    public float openAngle = 180; // Angle by which the door should open

    private bool isOpen = false; // Flag to track if the door is open or closed
    private Quaternion targetRotation; // Target rotation for smooth opening

    private void Start()
    {
        targetRotation = door.transform.rotation;
    }

    private void OnTriggerEnter(Collider other)
    {
        // Rigidbody rb = door.GetComponent<Rigidbody>();
        // rb.isKinematic = false;
        if (other.CompareTag("Player") && !isOpen && targetRotation == door.transform.rotation)
        {
            isOpen = true;
            targetRotation *= Quaternion.Euler(0, openAngle, 0);
        }
        else if (other.CompareTag("Player") && isOpen && targetRotation == door.transform.rotation)
        {
            isOpen = false;
            targetRotation *= Quaternion.Euler(0, -openAngle, 0);
        }
    }

    public bool IsOpen()
    {
        return isOpen;
    }

    private void Update()
    {
        door.transform.rotation = Quaternion.Slerp(door.transform.rotation, targetRotation, Time.deltaTime * 1);
    }
}