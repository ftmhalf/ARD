using UnityEngine;

public class Character2DController : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D _rigidbody;
    private Animator anim;
    private bool grounded;
	
	[SerializeField] private AudioSource jumpSoundEffect;
	[SerializeField] private AudioSource runSoundEffect;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        _rigidbody.velocity = new Vector2(horizontalInput * speed, _rigidbody.velocity.y);

        if (horizontalInput > 0.01f)
		{
            transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
			//runSoundEffect.Play();
		}
        else if (horizontalInput < -0.01f)
		{
            transform.localScale = new Vector3(-0.5f, 0.5f, 0.5f);
			//runSoundEffect.Play();
		}
		
        //if (!Mathf.Approximately(0, movement))
        //transform.rotation = movement > 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;

        if (Input.GetKey(KeyCode.Space) && grounded)
        {
                Jump();
        }
            
        anim.SetBool("run", horizontalInput != 0);
        anim.SetBool("grounded", grounded);
    }
    private void Jump()
    {
        _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, 7);
        anim.SetTrigger("jump");
        grounded = false;
		jumpSoundEffect.Play();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
		{
			grounded = true;
			runSoundEffect.Play();
		}
            
		runSoundEffect.Play();
    }
}
