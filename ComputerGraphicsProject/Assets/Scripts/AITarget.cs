using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(NavMeshAgent))]
public class AITarget : MonoBehaviour
{
    public Transform Target;
    public float attackDistance;

    private NavMeshAgent agent;
    private Animator animator;
    private float distance;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        Target = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(agent.transform.position, Target.position);
        if(distance < attackDistance)
        {
            SceneManager.LoadScene("GameOver");
        }
        else
        {
            agent.isStopped = false;
            agent.destination = Target.position;
        }
    }
}
