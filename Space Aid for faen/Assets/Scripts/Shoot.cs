using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Shoot : MonoBehaviour
{
    public GameObject toSpawn;
   
    public Camera cam;
    private Vector3 destination;

    public float projectileSpeed;

    public Transform firePoint;

    //public LayerMask aimColliderLayerMask = new LayerMask();
    public Transform debugTransform;

   // public CinemachineVirtualCamera playerCamera;
    public CinemachineFreeLook aimCamera;



    Vector3 velocity;
    //Vector3 Direction;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // Vector2 screenCenterPoint = new Vector2(Screen.width / 2f, Screen.height / 2f);
        //Ray ray = Camera.main.ScreenPointToRay(screenCenterPoint);
        //if (Physics.Raycast(ray, out RaycastHit raycasthit, 999f, aimColliderLayerMask))
       // {
         //   debugTransform.position = raycasthit.point;
        //}

        if (Input.GetMouseButton(1))
        
            aimCamera.Priority = 20;
            
        
        else
        
            aimCamera.Priority = 0;


        if (Input.GetMouseButtonDown(0) && aimCamera.Priority == 20) 
        {

            Shootprojectile();
        }


        void Shootprojectile()
        {
            Ray ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
                destination = hit.point;
            else
                destination = ray.GetPoint(100);

            var projectileObj = Instantiate(toSpawn, firePoint.position, Quaternion.identity) as GameObject;
            projectileObj.GetComponent<Rigidbody>().velocity = (destination - firePoint.position).normalized * projectileSpeed;

        }

        

    }
}