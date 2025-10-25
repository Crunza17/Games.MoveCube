using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 2f;

    private Rigidbody2D _rigidbody2D;
    private Vector2 moveInput;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();        
    }
    
    public void OnMove (InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }

    void FixedUpdate()
    {
        Vector2 newPosition = _rigidbody2D.position + moveInput * (moveSpeed * Time.fixedDeltaTime);
        _rigidbody2D.MovePosition(newPosition);
    }
}
