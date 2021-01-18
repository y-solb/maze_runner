using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour {

    Rigidbody myRigid;
    [SerializeField] private float moveSpeed;

    NavMeshAgent agent;

    [SerializeField] private Transform tf_Destination;
 
    Vector3 originPos;

    CharacterController CharacterController;
    Animator animator;

    void Start () {
        myRigid = GetComponent<Rigidbody>();
        agent = GetComponent<NavMeshAgent>();
        originPos = transform.position;

        CharacterController = GetComponent<CharacterController>();
        animator = GetComponentInChildren<Animator>();
    }
	
	void Update () {

        if (Vector3.Distance(this.transform.position, originPos) < 0.1f)
            agent.SetDestination(tf_Destination.position);

        else if (Vector3.Distance(this.transform.position, tf_Destination.position) < 0.1f)
            agent.SetDestination(originPos);
        


    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            animator.Play("Z_attack_A");
            

        }
       
    }
    /*void OnTriggerEnter(Collider col) //충돌 체크
    {
        if (col.name == "Player") StartCoroutine(SceneLoad()); //충돌시 코루틴 시작
    }

 
    IEnumerator SceneLoad()
    {
        yield return new WaitForSeconds(10f);
    }*/
}
