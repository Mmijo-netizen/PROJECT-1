using UnityEngine;

public class COLLECTIBLE : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        //Check if the other object has the tag "Player'
        if (other.gameObject.CompareTag("Player"))
        {

            //Response
            Debug.Log("Give player coins");

            //Destroy the collectible
            Destroy(gameObject);
        }

    }

}