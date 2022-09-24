using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class square : MonoBehaviour
{
    int type;
    float size;

    // Start is called before the first frame update
    void Start()
    {
        float x = Random.Range(-2.0f, 2.0f);
        float y = Random.Range(2.3f, 5.0f);
        transform.position = new Vector3(x, y, 0);

        type = Random.Range(1, 4);

        if(type == 1)
        {
            size = 2.0f;
        }
        else if(type == 2)
        {
            size = 1.3f;
        }
        else
        {
            size = 0.8f;
        }

        transform.localScale = new Vector3(size, size, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -6)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "balloon")
        {
            gameManager.I.gameOver();
        }
    }
}
