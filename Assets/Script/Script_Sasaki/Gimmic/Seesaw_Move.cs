using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seesaw_Move : MonoBehaviour
	//�V�[�\�[�̓X�N���v�g�œ����ĂȂ��ł��E�E�ERightbody�g���Ă��̂܂ܓ������Ă܂�
{
	Rigidbody rb;
    void Start()
    {
		rb = GetComponent<Rigidbody>();
	}
    void Update()
	{
		/*
		if (isStopAbilitySeesaw == true)
		{
			SeeasawMove();
		}
		else if (isStopAbilitySeesaw == false)
		{

		}*/
		if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow))
		{
			//rb.constraints = RigidbodyConstraints.FreezePosition
			//| RigidbodyConstraints.FreezeRotationZ;
			
			//isStopAbilitySeesaw = false;
		}
		else
		{
			//rb.isKinematic = false;
			//isStopAbilitySeesaw = true;
		}


	}
	/*
	private CharacterController characterController;
	private Animator animator;
	private Vector3 velocity = Vector3.zero;
	[SerializeField]
	private float walkSpeed = 1.5f;
	[SerializeField]
	private float jumpPower = 5f;

	//�@���ɗ^�����
	[SerializeField]
	private float power = 20f;

	void Start()
	{
		characterController = GetComponent<CharacterController>();
		//animator = GetComponent<Animator>();
	}

	void Update()
	{
		if (characterController.isGrounded)
		{
			velocity = Vector3.zero;
			var input = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));

			if (input.magnitude > 0f)
			{
				animator.SetFloat("Speed", input.magnitude);
				transform.LookAt(transform.position + input);
				velocity = transform.forward * walkSpeed;
			}
			else
			{
				animator.SetFloat("Speed", 0f);
			}

			if (Input.GetButtonDown("Jump")
				&& !animator.GetCurrentAnimatorStateInfo(0).IsName("Jump")
				&& !animator.IsInTransition(0)
			)
			{
				animator.SetBool("Jump", true);
				velocity.y += jumpPower;
			}
		}

		velocity.y += Physics.gravity.y * Time.deltaTime;
		characterController.Move(velocity * Time.deltaTime);
	}

	//�@���̃R���C�_�ƐڐG������
	void OnControllerColliderHit(ControllerColliderHit col)
	{
		//�@�m�F�̈׃��C�����o�I�Ɍ�����悤�ɂ���
		Debug.DrawLine(transform.position + Vector3.up * 0.1f, transform.position + Vector3.up * 0.1f + Vector3.down * 0.2f, Color.red);

		//�@rayPosition���牺�Ƀ��C���΂��ABlock���C���[�ɓ������Ă�����͂�������
		if (Physics.Linecast(transform.position + Vector3.up * 0.1f, transform.position + Vector3.up * 0.1f + Vector3.down * 0.2f, LayerMask.GetMask("Block")))
		{
			col.gameObject.GetComponent<Rigidbody>().AddForceAtPosition(Vector3.down * power, transform.position, ForceMode.Force);
		}
	}
	*/
}
