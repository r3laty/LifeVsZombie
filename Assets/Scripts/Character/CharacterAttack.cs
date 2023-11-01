using UnityEditor.PackageManager;
using UnityEngine;

public class CharacterAttack : MonoBehaviour
{
    [SerializeField] private float attackRange = 2;
    [SerializeField] private float damage = 2;
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Attack();
        }
    }
    private void Attack()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        if (Physics.Raycast(ray, out RaycastHit hit, attackRange))
        {
            Debug.DrawRay(ray.origin, ray.direction * hit.distance, Color.red);
            if (hit.collider != null)
            {
                bool isZombie = hit.collider.gameObject.TryGetComponent<ZombieHealth>(out ZombieHealth zombieHealth);
                if (isZombie)
                {
                    Debug.Log(hit.collider.name + " hitten name");
                    zombieHealth.TakeDamage(damage);
                }
            }
        }
    }
}