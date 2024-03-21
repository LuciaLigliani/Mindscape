using Inworld;
using UnityEngine;

public class PlayerInOutRoom : MonoBehaviour
{
    [SerializeField] InworldCharacter m_CurrentCharacter;
    [SerializeField] string m_Getin_Trigger;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && m_CurrentCharacter)
        {
            InworldController.CurrentCharacter = m_CurrentCharacter;
        }

        if (other.CompareTag("Player") && m_CurrentCharacter && m_Getin_Trigger != "")
        {
            InworldController.CurrentCharacter = m_CurrentCharacter;
            m_CurrentCharacter.SendTrigger(m_Getin_Trigger);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && m_CurrentCharacter)
        {
            InworldController.CurrentCharacter.CancelResponse();
            InworldController.CurrentCharacter = null;
        }

    }

}
