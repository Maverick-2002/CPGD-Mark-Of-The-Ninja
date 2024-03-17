using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour
{
    InputSystem controls;
    public Animator Animator;
    [SerializeField] private AudioSource AttackSound;
    public Transform attackpoint;
    public float attackrange = 0.5f;
    public LayerMask enemylayers;
    public int damage = 40;
    void Awake()
    {
        controls = new InputSystem();
        controls.Enable();
        controls.Player.SwordAttack.performed += ctx => Attack();
    }

    void Update()
    {
        
        {
            
           // Attack();
        }
    }
    void Attack()
    {
        Debug.Log("Attack");
        AttackSound.Play();
        Animator.SetTrigger("Attack");
        Collider2D[] hitenemy = Physics2D.OverlapCircleAll(attackpoint.position,attackrange, enemylayers);
        foreach(Collider2D enemy in hitenemy)
        {
            enemy.GetComponent<Enemy>().TakeDamage(40);

        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(attackpoint.position, attackrange);
    }
    private void OnEnable()
    {
        controls.Enable();
    }
    private void OnDisable()
    {
        controls.Disable();
    }

}
