using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerMovement : MonoBehaviour
{

    GameController gameController;
    SceneLoader sceneLoader;

    public Tilemap tilemap;
    public GameObject bomb;
    Vector3 worldPos;
    Vector3Int cell;
    Vector3 cellCenter;

    private float speed = 4f;
    private Animator animator;
    private Vector2 direction;

    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();
        Move();
    }

    public void Move()
    {
        transform.Translate(direction * speed * Time.deltaTime);


        if (direction.x != 0 || direction.y != 0)
        {
            Animate();
        }
        else
        {
            animator.SetLayerWeight(1, 0);
        }
    }

    public void Animate()
    {

        animator.SetLayerWeight(1, 1);

        animator.SetFloat("x", direction.x);
        animator.SetFloat("y", direction.y);
    }


    public void GetInput()
    {

        direction = Vector2.zero;

        if (Input.GetKey(KeyCode.W))
        {

            direction += Vector2.up;

        }

        if (Input.GetKey(KeyCode.A))
        {
            direction += Vector2.left;

        }

        if (Input.GetKey(KeyCode.S))
        {
            direction += Vector2.down;
        }

        if (Input.GetKey(KeyCode.D))
        {
            direction += Vector2.right;

        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            animator.SetBool("attack", true);

        }
        else
        {
            animator.SetBool("attack", false);
        }

        if (Input.GetKeyDown(KeyCode.B) && gameController.bombNum > 0)
        {

            worldPos = Camera.main.ScreenToWorldPoint(transform.position);
            cell = tilemap.WorldToCell(worldPos);
            cellCenter = tilemap.GetCellCenterWorld(cell);

            Instantiate(bomb, transform.position, Quaternion.identity);
            gameController.bombNum -= 1;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bomb"))
        {
            gameController.bombNum += 1;
            Destroy(collision.gameObject);
        }

        if (collision.CompareTag("Hurt"))
        {
            gameController.heartsNum -= 1;
            Debug.Log("Oh No.");
        }
        if (collision.CompareTag("Enemy"))
        {
            gameController.heartsNum -= 1;
            Debug.Log("Oh No.");
        }

        if (collision.CompareTag("Finish"))
        {
            Debug.Log("You did it!");
        }

        if (collision.CompareTag("Start"))
        {
            Debug.Log("Please find my Grandmother!");
        }
    }

}