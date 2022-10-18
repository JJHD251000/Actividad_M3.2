using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerMove : NetworkBehaviour
{
    public float runSpeed = 4;
    public float rotationSpeed = 200;
    public Animator animator;
    public GameObject bulletPrefab;
    public Transform bulletSpawn;

    private float x,y;

    public Rigidbody rb;
    public float jumpHeight = 1;

    public Transform groundCheck;
    public float groundDistance = 0.1f;
    public LayerMask groundMask;

    bool isGrounded;

    void Start() {
        if(isLocalPlayer) {
            GameObject cameraObject = GameObject.FindGameObjectWithTag("MainCamera");
            if(cameraObject != null) {
                cameraObject.transform.parent = gameObject.transform;
            }
            else {
                Debug.Log("Couldn't find MainCamera in scene");
            }
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        if(!isLocalPlayer) {
            return;
        }
        if(Input.GetKeyDown(KeyCode.F)) {
            CmdFire();
        }
        
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        transform.Rotate(0, x * Time.deltaTime * rotationSpeed, 0);
        transform.Translate(0, 0, y * Time.deltaTime * runSpeed);

        animator.SetFloat("VerX", x);
        animator.SetFloat("VerY", y);

        if(Input.GetKey("f")) {
            animator.SetBool("Other", false);
            animator.Play("Shooting");
        }
        if(x>0 || x<0 || y>0 || y<0) {
            animator.SetBool("Other", true);
        }

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(Input.GetKey("space") && isGrounded) {
            animator.Play("Jumping");
            Invoke("Jump", 0.5f);
        }
    }

    public void Jump() {
        rb.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
    }

    public override void OnStartLocalPlayer() {
        GetComponent<MeshRenderer>().material.color = Color.blue;
    }

    [Command]
    void CmdFire() {
        var bullet = (GameObject)Instantiate(
            bulletPrefab,
            bulletSpawn.position,
            bulletSpawn.rotation);

        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 6;
        NetworkServer.Spawn(bullet);

        Destroy(bullet, 2.0f);
    }
}
