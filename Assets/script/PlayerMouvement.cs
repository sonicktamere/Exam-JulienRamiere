
using UnityEngine;

public class PlayerMouvement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D body;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        //mouvement de droite a gauche avec la velociter du body.
       body.velocity = new Vector2(Input.GetAxis("Horizontal")* speed,body.velocity.y);
        //Jump avec la touche espace avec la velociter du body.
        if (Input.GetKey(KeyCode.Space))
            body.velocity = new Vector2(body.velocity.x, speed);
    }
}
