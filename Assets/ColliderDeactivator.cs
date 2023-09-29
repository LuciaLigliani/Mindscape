using UnityEngine;

public class ColliderDeactivator : MonoBehaviour
{
    public void DeactivateColliders(GameObject target)
    {
        Collider[] colliders = target.GetComponentsInChildren<Collider>();

        foreach (Collider collider in colliders)
        {
            collider.enabled = false;
        }
    }

    public void ActivateColliders(GameObject obj)
    {
        Collider[] colliders = obj.GetComponentsInChildren<Collider>();

        foreach (Collider collider in colliders)
        {
            collider.enabled = true;
        }
    }
}