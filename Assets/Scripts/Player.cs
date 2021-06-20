using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using TMPro;

using UnityEngine;

public class Player : Character
{
    //[SerializeField]
   // private Stat saude;
    //[SerializeField]
    //private Stat mana;

    //private float initHealth = 100, initMana = 50;
    
    //[SerializeField]
    //private GameObject flecha;
    
    //private Arma arma;
    //[SerializeField]
    //private GameObject[] inventariosArmas;

   
    //private bool encostou = false;

    public bool controlEnabled = true;

    Vector2 move;

    [SerializeField]
    private Transform exitPoints;
    // valor de qual "saida" será //

    [SerializeField]
    private Transform distancia;

    //private int index = 0;
    SpriteRenderer spriteRenderer;

    private bool isGrounded;
    [SerializeField]
    private float jumpForce;
    [SerializeField]
    private Transform pePos;
    [SerializeField]
    private float checkRadius;
    [SerializeField]
    private LayerMask whatIsGround;



    protected override void Start()
    {
        
        //saude.Initialize(initHealth, initHealth);
        //mana.Initialize(initMana, initMana);
        
        speed = 2f;
        spriteRenderer = GetComponent<SpriteRenderer>();
        base.Start();
    }

    // Update is called once per frame
    protected override void Update()
    {
        //directionMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;

        if (controlEnabled)
        {
            move.x = Input.GetAxisRaw("Horizontal");
            
            

        }
        else
        {
            move.x = 0;
        }
        isGrounded = Physics2D.OverlapCircle(pePos.position, checkRadius, whatIsGround);
        base.Update();
       
    }
    protected override void ComputeVelocity()
    {
        if (isGrounded)
        {
            animator.SetBool("pulando", false);
        }
        
        if (move.x > 0.01f)
        {
            spriteRenderer.flipX = false;
        }
        else if(move.x < -0.01f)
        {
            spriteRenderer.flipX = true;
        }
        animator.SetFloat("velocityX", Mathf.Abs(move.x) / 7);
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = 4f;
            animator.SetBool("correndo", true);
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 2f;
            animator.SetBool("correndo", false);
        }
        direction.x = move.x;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded)
            {
                myRigidbody.velocity = Vector2.up * jumpForce;
                direction.y = move.y * jumpForce;
                
                

            }
           
           
        }
        if (!isGrounded)
        {
            animator.SetBool("pulando", true);
        }
        
        
        
        
    }
    private void GetInput()
    {
       

        /*if (Input.GetKey(KeyCode.W))
        {
            
            direction += Vector2.up;
        }
        if (Input.GetKey(KeyCode.S))
        {
            
            direction += Vector2.down;
        }
        if (Input.GetKey(KeyCode.D))
        {
            
            direction += Vector2.right;
        }
        if (Input.GetKey(KeyCode.A))
        {
            
            direction += Vector2.left;
        }*/
        if (controlEnabled)
        {
            direction.x = Input.GetAxis("Horizontal");
            print("apertei");

        }

        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            
            if (  !isAttacking && !IsMoving && DistanciaFlecha())
        {
                
                attackRoutine = StartCoroutine(Attack());
        }
        
        }*/
       
        /*if (Input.GetKeyDown(KeyCode.Z))
        {
            if(index == 0)
            {
                index = 1;
                inventariosArmas[index].SetActive(true);
                inventariosArmas[index - 1].SetActive(false);

            }
            else
            {
                index = 0;
                inventariosArmas[index].SetActive(true);
                inventariosArmas[index + 1].SetActive(false);

            }
            
        }*/
    }
    /*public IEnumerator Attack()
    {
        isAttacking = true;
        animator.SetBool("Attack", isAttacking);
        UsarArma();
       
        yield return new WaitForSeconds(0.3f); // esse é o tempo do codigo //
        StopAttack();
        arma.stopArma();
        
    }*/
    /*public void UsarArma()
    {
        
        arma = inventariosArmas[index].GetComponent<Arma>();
        arma.usarArma();
        //Instantiate(espada, exitPoints.position, Quaternion.identity);
        Instantiate(flecha, exitPoints.position, Quaternion.identity);
        


    }*/

    private bool DistanciaFlecha()
    {
        Vector3 targetDirection = Vector2.right;
        RaycastHit2D hit = Physics2D.Raycast(transform.position, targetDirection, Vector2.Distance(transform.position, distancia.position),256);
        if (hit.collider == null)
        {
            
            return true;
        }
        return false;
    }
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        
        

    }
}

