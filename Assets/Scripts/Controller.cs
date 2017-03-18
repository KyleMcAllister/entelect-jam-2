using UnityEngine;

public class Controller : MonoBehaviour
{
    public float MaxSpeed = 10.0f;
    public float JumpModifierY = 5.0f;
	public float JumpModifierX = 0.0f;
    private float horizontalInput;
    private Rigidbody2D rigidbody2D;
    private bool jumpButtonPressed;
	private bool canJump = true;

	public SpriteRenderer spriteRenderer;

	public Sprite jumpSprite;
	public Sprite nonJumpSprite;

    // Use this for initialization
	private void Start ()
	{
	    this.rigidbody2D = this.gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	private void Update ()
	{
	    this.horizontalInput = Input.GetAxis("Horizontal");

	    this.jumpButtonPressed = Input.GetButtonDown("Jump");
	}

    //FixedUpdate is called every fixed framerate frame
    private void FixedUpdate()
    {
        var speed = this.MaxSpeed * this.horizontalInput;
        var moveSpeed = new Vector2(speed, this.rigidbody2D.velocity.y);
        this.rigidbody2D.velocity = moveSpeed;

		if(this.jumpButtonPressed && this.canJump)
        {
			var jumpForce = new Vector2(this.JumpModifierX, this.JumpModifierY);
            this.rigidbody2D.AddForce(jumpForce, ForceMode2D.Impulse);
        }

		if (this.horizontalInput > 0) {
			this.spriteRenderer.flipX = false;
		} else if (this.horizontalInput == 0) {
		}
		else {
			this.spriteRenderer.flipX = true;
		}

		if (!canJump) {
			this.spriteRenderer.sprite = jumpSprite;
		} else {
			this.spriteRenderer.sprite = nonJumpSprite;
		}
    }

	void OnTriggerEnter2D(Collider2D other) {
		switch (other.tag) {
			case "Enemy":
				Destroy(other.gameObject);
				break;
			case "block":
			case "ground":
				canJump = true;
				break;
			default:
				break;
		}
	}

	void OnTriggerExit2D(Collider2D other){
		switch (other.tag) {
			case "block":
			case "ground":
				canJump = false;
				break;
			default:
				break;
		}
	}
}
