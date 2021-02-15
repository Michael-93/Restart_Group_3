using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DoorTrigger : MonoBehaviour
{

    public float smoothTime = 0.3F;
    private Vector3 velocity = Vector3.zero;
    public float x;
    public Transform target;
    public float Doormovetime;
    public float TimeDoorStops;
    

    [SerializeField]
    GameObject door;
    bool isOpened = false; 



    void OnTriggerEnter(Collider other)

    {
        if (other.tag == "Player")
        isOpened = true;
   

    }

    private void Update()
    {
        if (isOpened == true)
        {
         Vector3 targetPosition = door.transform.position + new Vector3(0, x, 0);
         door.transform.position = Vector3.SmoothDamp(door.transform.position, targetPosition, ref velocity, smoothTime);
            Doormovetime += Time.deltaTime;
                if (Doormovetime >= TimeDoorStops)
            {
                isOpened = false;
                Destroy(door);
            }
        }
        
        
    }
}
