using UnityEngine;

public class PowerUpTrigger : MonoBehaviour
{
    public HealingPowerUp healingPowerUp; // Reference to your HealingPowerUp Scriptable Object.

    public CarHealth carHealth;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
        
            if (carHealth != null)
            {
                healingPowerUp.ApplyHealing(carHealth);
                Destroy(gameObject); // Destroy the power-up object after use.
            }
        }
    }
}
