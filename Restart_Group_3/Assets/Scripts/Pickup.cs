using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;




public class Pickup : MonoBehaviour
{
    public GameObject Cheese;
    public static int CheeseCount;
    public TextMeshProUGUI CheeseText;
    public AudioClip EatSound;

    private void Start()
    {
        CheeseCount = 0;
    }


    private void OnTriggerEnter(Collider other)
        {
            Cheese = GameObject.FindGameObjectWithTag("Cheese");

            if (gameObject != null)
            {
                AudioSource.PlayClipAtPoint(EatSound, other.transform.position);
                CheeseCount++;
                CheeseText.text = CheeseCount.ToString();
                Destroy(gameObject);

            }
        }

    }

