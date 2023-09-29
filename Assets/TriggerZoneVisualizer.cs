using UnityEngine;

using UnityEngine;

public class DebugGizmoDrawer : MonoBehaviour
{
    private void OnDrawGizmosSelected()
    {
        // Iterate through all GameObjects with a Collider component in the scene
        Collider[] colliders = FindObjectsOfType<Collider>();
        foreach (Collider collider in colliders)
        {
            // Set Gizmo color (e.g., green)
            Gizmos.color = Color.green;

            // Draw the wireframe representation of the Collider
            Gizmos.DrawWireCube(collider.bounds.center, collider.bounds.size);
        }
    }
}
