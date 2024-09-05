using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class RobotMove : MonoBehaviour
{
    //Properties
    private SpriteRenderer _spriteRobot;
    [SerializeField] private float _speed = 5;
    [SerializeField] private float _forceJump = 100;
    // Start is called before the first frame update
    void Start()
    {
        _spriteRobot = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * _speed * Time.deltaTime);
            _spriteRobot.flipX = false;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.right * _speed * Time.deltaTime * -1);
            _spriteRobot.flipX = true;
        }
        if ( Input.GetKeyUp(KeyCode.W))        
            transform.Translate(Vector2.up * _forceJump * Time.deltaTime);
        
    }
}
