using System;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health;

    public event Action<int> OnHealthChanged;

    public void TakeDamage(int damage)
    {
        health -= damage;
        OnHealthChanged?.Invoke(health);
        if (health == 0)
            Destroy(gameObject);
    }

    public void AddHealth(int heal)
    {
        if (health == 6) return;

        health += heal;
        OnHealthChanged?.Invoke(health);
    }
}
