using UnityEngine;

public class ZombieController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 2;

    private Transform _target;
    private AudioSource _takeDamageSound;
    private void Start()
    {
        _target = GameObject.FindGameObjectWithTag("Player").transform;
        _takeDamageSound = _target.GetComponentInChildren<AudioSource>();
    }

    private void Update()
    {
        if (_target != null)
        {
            MoveTowardsTarget();
        }
    }
    private void MoveTowardsTarget()
    {
        transform.LookAt(_target.position);
        Vector3 targetPosition = _target.position;
        Vector3 currentPosition = transform.position;

        Vector3 newPosition = Vector3.MoveTowards(currentPosition, targetPosition, moveSpeed * Time.deltaTime);

        transform.position = newPosition;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (_takeDamageSound != null)
            {
                Debug.Log("Worked");
                _takeDamageSound.Play();
            }
            else
            {
                Debug.Log("AAAAAAAAAAAAAA");
            }
        }
    }
}
