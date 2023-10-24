using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class Movement : MonoBehaviour
{
    [SerializeField] private float speed = 1;

    private Rigidbody _characterRigidbody;
    private float _horizontalInput;
    private float _verticalInput;
    private bool _speedUp;
    private bool _speedDown;
    private void Awake()
    {
        _characterRigidbody = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        _horizontalInput = Input.GetAxisRaw("Horizontal");
        _verticalInput = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown(KeyCode.LeftShift))
            _speedUp = true;
        if (Input.GetKeyUp(KeyCode.LeftShift))
            _speedDown = true;
    }
    private void FixedUpdate()
    {
        if (_speedUp)
        {
            speed *= 2;
            _speedUp = false;
        }
        if (_speedDown)
        {
            speed /= 2;
            _speedDown = false;
        }

        Vector3 moveTowards = transform.right * _horizontalInput + transform.forward * _verticalInput;
        moveTowards = moveTowards.normalized * speed * Time.fixedDeltaTime;
        _characterRigidbody.velocity = moveTowards;
    }
}
