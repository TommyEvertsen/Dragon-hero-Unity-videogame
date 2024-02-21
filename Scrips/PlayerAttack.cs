using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private Animator animator;
    private PlayerMovement playerMovement;
    [SerializeField] private float attackCoolDown;
    [SerializeField] private Transform firePoint;
    [SerializeField] private GameObject[] fireballs;
    private float coolDownTimer = 999;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    private void Awake()
    {
       animator = GetComponent<Animator>();
       playerMovement = GetComponent<PlayerMovement>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && coolDownTimer > attackCoolDown && playerMovement.canAttack())
        {
            // attack();


        }
    }

    //private void attack()
    // {
    // animator.SetTrigger("Attack");
    // coolDownTimer = 0;

    // fireballs[FindFireBall()].transform.position = firePoint.position;
    // fireballs[FindFireBall()].GetComponent<Projectile>().SetDirection(Mathf.Sign(transform.localScale.x));

    // coolDownTimer += Time.deltaTime;
    //}

    private int FindFireBall()
    {
        for(int i = 0; i < fireballs.Length; i++)
        {
            if (!fireballs[i].activeInHierarchy) 
                return i; 
            
        }

        return 0;

    }
}
