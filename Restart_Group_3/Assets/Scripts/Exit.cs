
using UnityEngine;
using UnityEngine.SceneManagement;


public class Exit : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {

        SceneManager.LoadScene("Win");

    }
    private void Start()
    {

        
    }

    private void Update()
    {
        
    }



}
