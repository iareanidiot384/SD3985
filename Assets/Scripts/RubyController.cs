using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RubyController : MonoBehaviour
{
    float horizontal;
    float vertical;
    public float movementSpeed = 10;
    public int hp { get { return currenthp; }}
    public int currenthp;
    public int maxhp = 30;

    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
       /* QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 10;*/
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        Vector2 positionToMove = new Vector2(horizontal, vertical) * movementSpeed * Time.fixedDeltaTime;
        Vector2 newPos = (Vector2)transform.position + positionToMove;

        rb.MovePosition(newPos);
    }

    public void hpChange(int value)
    {
        currenthp += value;

        if (currenthp > maxhp)
        {
            currenthp = maxhp;
        }
        if (currenthp < 0)
        {
            currenthp = 0;
        }

        currenthp = Mathf.Clamp(hp, 0, maxhp);

        Debug.Log("Player HP is now: " + hp);

    }
    
}