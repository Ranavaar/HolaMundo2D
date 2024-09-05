using UnityEngine;
using System;
using Unity.VisualScripting;

public class RobotAnimatorController : MonoBehaviour
{
	#region Properties
	#endregion
	private Animator _robotAnim;	
	#region Fields
	[SerializeField] private Animator _animator;
	#endregion

	#region Unity Callbacks
	// Start is called before the first frame update
	void Start()
    {		
        _robotAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

		//Set Animator properties state
		if (Input.GetKeyDown(KeyCode.D))
			_robotAnim.SetBool("Run", true);
        if (Input.GetKeyDown(KeyCode.A) )
            _robotAnim.SetBool("Run", true);

        if (Input.GetKeyUp(KeyCode.D))
            _robotAnim.SetBool("Run", false);
        if (Input.GetKeyUp(KeyCode.A))
            _robotAnim.SetBool("Run", false);

        if (Input.GetKeyDown(KeyCode.Mouse0))
            _robotAnim.SetTrigger("Attack");

        if (Input.GetKeyDown(KeyCode.Return))
            _robotAnim.SetTrigger("Hit");

    }
	#endregion  

	#region Public Methods
	#endregion

	#region Private Methods
	#endregion
}
