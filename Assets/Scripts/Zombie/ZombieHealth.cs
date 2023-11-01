using UnityEngine;

public class ZombieHealth : MonoBehaviour
{
    public float hp = 4;

    public void TakeDamage(float damage)
    {
        hp -= damage;
        if (hp < 0)
        {
            Die();
        }
    }
    private void Die()
    {
        Destroy(gameObject);
    }
}
