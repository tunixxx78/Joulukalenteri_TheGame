using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    public NavMeshAgent playerNavMeshAgent;
    public Camera playerCamera;
    


    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray myRay = playerCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit myRaycastHit;

            if(Physics.Raycast(myRay, out myRaycastHit))
            {
                playerNavMeshAgent.SetDestination(myRaycastHit.point);
            }
        }

        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Gift"))
        {
            Debug.Log("PELAAJA OSUI LAHJAAN!");
            var target = FindObjectOfType<TargetIndicator>();
            Debug.Log(target);

            if(target.gameObject.activeSelf == true)
            {
                target.gameObject.SetActive(false);

                Debug.Log(target);
            }
            else
            {
                
            }

            
            
        }
        
    }

}
