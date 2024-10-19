using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float speed;

    private SpriteRenderer _spriteRenderer;
    private Animator _animator;
    
    private static readonly int Horizontal = Animator.StringToHash("Horizontal");
    private static readonly int Vertical = Animator.StringToHash("Vertical");
    private static readonly int IsWalking = Animator.StringToHash("IsWalking");

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _animator = GetComponent<Animator>();
    }
    
    private void Update()
    {
        var movement = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        transform.position += movement * (speed * Time.deltaTime);
        
        if (movement.magnitude > 0)
        {
            _animator.SetFloat(Horizontal, movement.x);
            _animator.SetFloat(Vertical, movement.y);
            _spriteRenderer.flipX = -movement.x < 0;
        }
        _animator.SetBool(IsWalking, movement.magnitude > 0);
    }
}
