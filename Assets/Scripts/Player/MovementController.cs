using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    [SerializeField] private Rigidbody rigidBody;
    [SerializeField] private float impulseUpStrenght;
    [SerializeField] private float impulseForwardStrenght;
    [SerializeField] private float torqueStrenght;


    private bool isStuck;
    private RigidbodyConstraints unstuckConstraints =
    RigidbodyConstraints.FreezePositionZ |
    RigidbodyConstraints.FreezeRotationX |
    RigidbodyConstraints.FreezeRotationY;
    private RigidbodyConstraints stuckConstraints = RigidbodyConstraints.FreezeAll;


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
            addForce();
    }


    public void addForce()
    {
        if (isStuck)
        {
            isStuck = false;
            rigidBody.freezeRotation = true;
            rigidBody.constraints = unstuckConstraints;
        }
        rigidBody.AddForce(new Vector3(0.5f * impulseForwardStrenght, 1 * impulseUpStrenght, 0));
        rigidBody.AddTorque(transform.forward * torqueStrenght);
    }

    public void enterStuckState()
    {
        isStuck = true;
        rigidBody.velocity = Vector3.zero;
        rigidBody.angularVelocity = Vector3.zero;
        rigidBody.constraints = stuckConstraints;
    }
}
