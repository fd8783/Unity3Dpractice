using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IKCtrl : MonoBehaviour {

	public float rightHandIKWeight;

	public Transform targetRightHand, targetRightHint;


	private Animator anim;

	// Use this for initialization
	void Awake () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnAnimatorIK (int layerIndex)
	{
		anim.SetIKPositionWeight(AvatarIKGoal.RightHand, rightHandIKWeight);
		anim.SetIKRotationWeight(AvatarIKGoal.RightHand, rightHandIKWeight);
		anim.SetIKPosition(AvatarIKGoal.RightHand, targetRightHand.position);
		anim.SetIKRotation(AvatarIKGoal.RightHand, targetRightHand.rotation);
		anim.SetIKHintPosition(AvatarIKHint.RightElbow, targetRightHint.position);
		anim.SetIKHintPositionWeight(AvatarIKHint.RightElbow, rightHandIKWeight);

	}
}
