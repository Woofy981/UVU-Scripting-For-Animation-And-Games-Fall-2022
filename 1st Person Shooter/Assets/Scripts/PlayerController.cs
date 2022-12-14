using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed; public float jumpForce; 
    [Header("Health")]
    public int curHp; public int maxHp;
    [Header("Attack")]
    public int attackPower;
    [Header("Camera")]
    public float lookSensitivity; public float maxLookX; public float minLookX; private float rotX;
    private Camera camera;
    private Rigidbody rb;
    private Enemy enemy;

    // Start is called before the first frame update
    void Start()
    {
        camera = Camera.main;
        rb = GetComponent<Rigidbody>();
        enemy = GameObject.Find("Enemy").GetComponent<Enemy>();
        curHp = maxHp;
    }

    public void TakeDamage(int damage)
    {
        curHp -= damage;

        if(curHp <= 0){
            Die();
        }
    }
    
     void Die()
    {
        GameManager.instance.LoseGame();
        Time.timeScale = 0;
    }

    void Move()
    {
        float x = Input.GetAxis("Horizontal") * moveSpeed;
        float z = Input.GetAxis("Vertical") * moveSpeed;

        //rb.velocity = new Vector3(x, rb.velocity.y, z);
        Vector3 dir = transform.right * x + transform.forward * z;

        dir.y = rb.velocity.y;
        rb.velocity = dir;
    }

     void CamLook()
    {
        float y = Input.GetAxis("Mouse X") * lookSensitivity;
        rotX += Input.GetAxis("Mouse Y") * lookSensitivity;

        rotX = Mathf.Clamp(rotX, minLookX, maxLookX);

        camera.transform.localRotation = Quaternion.Euler(-rotX, 0, 0);
        transform.eulerAngles += Vector3.up * y;
    }

    void Jump()
    {
        Ray ray = new Ray(transform.position, Vector3.down);

        if(Physics.Raycast(ray, 3.5f))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    public void GiveHealth(int amountToGive)
    {
        curHp = Mathf.Clamp(curHp + amountToGive, 0, maxHp);
    }

    public void GiveAmmo(int amountToGive)
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        CamLook();

        if(Input.GetButton("Fire1")){
            enemy.TakeDamage(attackPower);
        }

        if(Input.GetButtonDown("Jump")){
            Jump();
        }

        if(GameManager.instance.gamePaused == true){
            return;
        }
    }
}
