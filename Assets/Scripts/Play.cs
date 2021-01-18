using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Play : MonoBehaviour {

    public float moveSpead = 5f;
    public float rotationSpeed = 360f;
    public GameObject obj1;
    public GameObject obj2;

    CharacterController CharacterController;
    Animator animator;



    void Start() {
        CharacterController = GetComponent<CharacterController>();
        animator = GetComponentInChildren<Animator>();

    }

    void Update() {

        Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        if (direction.sqrMagnitude > 0.01f)
        {
            Vector3 forward = Vector3.Slerp(
                transform.forward, direction, rotationSpeed * Time.deltaTime / Vector3.Angle(transform.forward, direction)
                );
            transform.LookAt(transform.position + forward);
        }
        CharacterController.Move(direction * moveSpead * Time.deltaTime);

        animator.SetFloat("Speed", CharacterController.velocity.magnitude);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            animator.Play("f_death_A");
            Invoke("GmOver", 2);
            GameObject.Find("Player").GetComponent<Animator>().SetTrigger("StopMoving");

        }
        
    }

    void GmOver()
        {
            obj1.SetActive(true);
        }
    public GameObject[] apps;
    int count = 0;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Apple")
        {

            Destroy(other.gameObject);
            apps[count].SetActive(true);
            count = count + 1;
        }

        else if (other.tag == "house" && count == 6)
        {
            
                obj2.SetActive(true);
            
        
        }
    }
}
