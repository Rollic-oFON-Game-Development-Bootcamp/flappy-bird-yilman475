using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float flyForce = 100f;
    private Rigidbody2D rb;
    private bool isDead;

    public GameManager manager;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
            Fly();
 
        RotationAngle();
    }

    private void Fly()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(Vector2.up * flyForce);
        }
    }

    private void RotationAngle()
    {
        float rotationAngle = Mathf.Clamp(rb.velocity.y *25f, -70f, 30f);
        transform.eulerAngles = new Vector3(0, 0, rotationAngle);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Death")
        {
            isDead = true;
            Time.timeScale = 0;
            //SceneManager.LoadScene(0);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.gameObject.name)
        {
            case "point":
            case "point1":
                manager.UpdateScore();
            break;
        }        
    }

}



/*void DoDelayAction(float delayTime)
{
    StartCoroutine(DelayAction(delayTime));
}

IEnumerator DelayAction(float delayTime)
{

    yield return new WaitForSeconds(delayTime);

} */