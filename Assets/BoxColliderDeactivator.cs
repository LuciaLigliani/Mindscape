using UnityEngine;

public class BoxColliderDeactivator : MonoBehaviour
{
    public void DeactivateBoxColliders(GameObject target)
    {
        BoxCollider[] colliders = target.GetComponentsInChildren<BoxCollider>();

        foreach (BoxCollider collider in colliders)
        {
            collider.enabled = false;
        }
    }

    public void ActivateBoxColliders(GameObject obj)
    {
        BoxCollider[] colliders = obj.GetComponentsInChildren<BoxCollider>();

        foreach (BoxCollider collider in colliders)
        {
            collider.enabled = true;
        }
    }
}