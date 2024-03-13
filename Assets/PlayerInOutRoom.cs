using Inworld;
using UnityEngine;

public class PlayerInOutRoom : MonoBehaviour
{
    [SerializeField] InworldCharacter m_CurrentCharacter;
    [SerializeField] string m_Getin_Trigger;
    [SerializeField] string m_Getout_Trigger;
    [SerializeField] string m_Closedoor_Trigger;
    [SerializeField] DoorController m_DoorController;
    [SerializeField] DoorController m_DoorController2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && m_CurrentCharacter)
        {
            m_CurrentCharacter.SendTrigger(m_Getin_Trigger);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if ((m_DoorController && m_DoorController2 && other.CompareTag("Player") && m_CurrentCharacter && (m_DoorController.IsOpen() == true || m_DoorController2.IsOpen() == true)) ||  (m_DoorController && other.CompareTag("Player") && m_CurrentCharacter && m_DoorController.IsOpen() == true))
        {
            m_CurrentCharacter.SendTrigger(m_Closedoor_Trigger);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && m_CurrentCharacter)
        {
            m_CurrentCharacter.CancelResponse();
            m_CurrentCharacter.SendTrigger(m_Getout_Trigger);
        }
    }



}
