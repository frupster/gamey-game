using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
public class EnemyAI : MonoBehaviour
{
    Animator animator;
    public NavMeshAgent agent;

    public Transform player;

    public LayerMask whatIsGround, whatIsPlayer;

    private PlayerInteract playerInteract;

    public GameObject skull;

    //Patrolling
    public Vector3 walkPoint;
    bool walkPointSet;
    public float walkPointRange;
    private bool chased;
    public bool chasing;
    //Attacking
    public float timeBetweenAttacks;
    bool alreadyAttacked;
    public bool hit = false;

    //States
    public float sightRange, attackRange;
    public bool playerInSightRange, playerInAttackRange;

    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip ringing;

    //private Switch lever;

    //public Vector3 spawnPoint;
    public GameObject enemy;
    Vector3 spawnPoint = new Vector3(38.73f, 5.08f, 3.52f);

    public bool second = false;
    private Skull skeleHead;

    private void Awake()
    {
        player = GameObject.Find("Player").transform;
        agent = GetComponent<NavMeshAgent>();
        skeleHead = GameObject.Find("skull").GetComponent<Skull>();
    }

    private void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        playerInteract = GameObject.Find("Player").GetComponent<PlayerInteract>();
        // if (audioSource == null) Debug.Log("audio source is null");

        //lever = GameObject.Find("Lever Switch").GetComponent<Switch>();
        
    }
    private void Update()
    {
        //check for sight and attack range
        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);
        playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, whatIsPlayer);

        if (!playerInSightRange && !playerInAttackRange)
        {
            skeleHead.chasing = false;
            Patroling();
        }
        if (playerInSightRange && !playerInAttackRange)
        {
            chasing = true;
            skeleHead.chasing = true;
            ChasePlayer();
        }
        else chasing = false;
        if (playerInAttackRange && playerInSightRange) AttackPlayer();

       if (playerInteract.flipped == true)
        {
            Destroy(gameObject);
            Instantiate(enemy, spawnPoint, Quaternion.identity);
            Instantiate(skull, new Vector2 (1000, 1000), Quaternion.identity);
          playerInteract.flipped = false;
            playerInteract.flipped1 = true;

        }

       if(playerInteract.mushroomCount == 1)
        {
           RenderSettings.fogDensity = 0.02f;
            RenderSettings.fogColor = Color.red;
            sightRange = 100;
            
        }
    }
    private void Patroling()
    {
        
        if (!walkPointSet) SearchWalkPoint();

        if (walkPointSet)
            agent.SetDestination(walkPoint);

        Vector3 distanceToWalkPoint = transform.position - walkPoint;

        //walkpoint reached
        if (distanceToWalkPoint.magnitude < 1f)
            walkPointSet = false;
        
        if (chased == true)
        {
            audioSource.Stop();
            chased = false;
        }
    }

    private void SearchWalkPoint()
    {
        //calculate random point in range
        float randomZ = Random.Range(-walkPointRange, walkPointRange);
        float randomX = Random.Range(-walkPointRange, walkPointRange);

        walkPoint = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);

        if (Physics.Raycast(walkPoint, -transform.up, 2f, whatIsGround))
            walkPointSet = true;
    }

    private void ChasePlayer()
    {
        agent.SetDestination(player.position);
        //animator.SetBool("isAttacking", true);
        audioSource.PlayOneShot(ringing);
        chased = true;
        
    }
    private void AttackPlayer()
    {
        agent.SetDestination(transform.position);
        transform.LookAt(player);
        

        if (!alreadyAttacked)
        {
            //attack code here
            //hit = true;
            SceneManager.LoadScene("Death");
            animator.SetBool("isAttacking", true);


            alreadyAttacked = true;
            Invoke(nameof(ResetAttack), timeBetweenAttacks);
        }
    }

    private void ResetAttack()
    {
        alreadyAttacked = false;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, sightRange);
    }

    




}
