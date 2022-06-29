using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed = 0.1f;

    private Player _target;
    private Rigidbody _rigidbody;

    public void Init(Player target)
    {
        _target = target;
    }

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        MoveTowardsPlayer();
    }

    private void MoveTowardsPlayer()
    {
        var newPosition = Vector3.MoveTowards(transform.position, _target.transform.position, _speed);
        _rigidbody.MovePosition(newPosition);
    }
}
