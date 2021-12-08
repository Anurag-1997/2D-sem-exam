using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private PlayerInputActions PIA;
    private Rigidbody2D rb2d;
    [SerializeField] float speed = 10f;

    private void Awake()
    {
        PIA = new PlayerInputActions();
        rb2d = GetComponent<Rigidbody2D>();
    }
    private void OnEnable()
    {
        PIA.Enable();
    }
    private void OnDisable()
    {
        PIA.Disable();
    }
    private void FixedUpdate()
    {
        Vector2 moveInput = PIA.Movement.Move.ReadValue<Vector2>();
        rb2d.velocity = moveInput * speed;
    }
}
