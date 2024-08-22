using UnityEngine;

public class PlayerMovement : MonoBehaviour

{
    private float xInput;
    private float yInput;
    private bool isFacingLeft;
    private bool isPlayerMoving;
    [SerializeField] private float speed;
    [SerializeField] private float jumpSpeed;

    private Animator animator;

    public void Start()
    {
        isFacingLeft = true;
        animator = GetComponent<Animator>();
    }

    public void Update()
    {
        Move();
        Flip();
        Animation();
    }

    private void Animation()
    {
        isPlayerMoving = xInput != 0;
        animator.SetBool("isPlayerMoving", isPlayerMoving);
    }

    private void Move()
    {
        xInput = Input.GetAxisRaw("Horizontal") * speed;
        yInput = Input.GetAxisRaw("Jump") * jumpSpeed;

        if(isFacingLeft)
            transform.Translate(new Vector3(xInput, yInput, 0));
        else
            transform.Translate(new Vector3(-xInput, yInput, 0));
    }

    private void Flip()
    {
        if (xInput > 0)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));
            isFacingLeft = false;
        }           
        else if (xInput < 0)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
            isFacingLeft = true;
        }       
    }
}
