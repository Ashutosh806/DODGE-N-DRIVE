using UnityEngine;

public class PowerUpController : MonoBehaviour
{
    public SpeedPowerUp speedPowerUp;
    public CarController carController;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            ApplyPowerUp();
            Destroy(gameObject); 
        }
    }

    private void ApplyPowerUp()
    {
        carController.fwdSpeed += speedPowerUp.speedIncreaseAmount;
    }
}
