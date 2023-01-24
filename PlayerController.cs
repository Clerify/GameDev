using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //Declare the Rigidbody2D for the player
    Rigidbody2D _rb;
    //Declare the script from the ObjectBevaior. (I wrote it wrong, it suppose to be ObjectBehaviour)
   [SerializeField] ObjectBehavior _objectBehavior;

    //Fields
    private float _playerSpeed = 30;
    private float  _InputHorizontal; 

    // Start is called before the first frame update
    void Start()
    {
        //Setup the RigidBody: It's must: GetComponent
        _rb = gameObject.GetComponent<Rigidbody2D>();
        //Call SpawnObject for the Object
        //Usually you will have a game master file that has all the spawning in it, not in the actual
        //player script.
        _objectBehavior.SpawnObject();
    }

    // Update is called once per frame
    void Update()
    {

        //Movement: 
        _InputHorizontal = Input.GetAxisRaw("Horizontal");

        if(_InputHorizontal != 0)
        {
            _rb.AddForce(new Vector2(_InputHorizontal * _playerSpeed, 0f));
        }

    }
}
