using UnityEngine;

[CreateAssetMenu(fileName = "New Healing Power-Up", menuName = "Power-Ups/Healing Power-Up")]
public class HealingPowerUp : ScriptableObject
{
    public int healingAmount = 10; 

    public void ApplyHealing(CarHealth carHealth)
    {
        carHealth.Heal(healingAmount);
    }
}
