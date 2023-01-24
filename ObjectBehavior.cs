using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBehavior : MonoBehaviour
{

    bool _gameOver = false;
    
    //Grab the prefab
    [SerializeField] GameObject prefab;
   public void SpawnObject()
   {
    Instantiate(prefab, new Vector3(Random.Range(-8f,8f),6f,0f), Quaternion.identity);
   }

    //Listens to a collision between two objects.
    //So from the parameters the Collision 2D is the object the script is attached to.
    // and the collision is the player if the object hits the player, or it's the ground of the object hits
    // the ground.
   private void OnCollisionEnter2D(Collision2D collision) 
   {
        if (collision.gameObject.tag == "Player" && !_gameOver)
        {
            ScoreScript._scoreValue += 1; //This is the same as : .._scorevalue = scoreValue + 1;  
            SpawnObject();
            Destroy(gameObject); 
        }
        else if (collision.gameObject.tag == "Ground")
        {
            _gameOver = true;
            Debug.Log("GAME OVER , YOU LOSE! ");
        }

   }

    
}
