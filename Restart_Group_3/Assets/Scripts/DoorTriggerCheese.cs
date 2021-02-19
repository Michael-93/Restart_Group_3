using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DoorTriggerCheese : MonoBehaviour
{
    
    public bool cheeserequirementmet = false;
    public int cheeserequirement;
    public static int CheeseCount;
    public float smoothTime = 0.3F;
    private Vector3 velocity = Vector3.zero;
    public float x;
    public float Doormovetime;
    public float TimeDoorStops;
    

    [SerializeField]
    GameObject door;
    bool isOpened = false;

        private void Update()
        {

        if (Pickup.CheeseCount >= cheeserequirement)
            {
                cheeserequirementmet = true;
                isOpened = true;
        }

        if (cheeserequirementmet == true && isOpened == true)
            {
               
            Vector3 targetPosition = door.transform.position + new Vector3(0, x, 0);
            door.transform.position = Vector3.SmoothDamp(door.transform.position, targetPosition, ref velocity, smoothTime);
            Doormovetime += Time.deltaTime;
            if (Doormovetime >= TimeDoorStops)
            {
                isOpened = false;
                Destroy(door);
                door = null;
                
            }
        }
    }
    }

