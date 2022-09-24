using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public GameObject square;
    public Text timetext;
    public GameObject gameOverTxt;

    public static gameManager I;

    float alive = 0.0f;

    public Animator anim;
    public GameObject balloon;

    private void Awake()
    {
        I = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("makeSquare", 0, 0.5f);
    }

    void makeSquare ()
    {
        Instantiate(square);
    }

    // Update is called once per frame
    void Update()
    {
        alive += Time.deltaTime;
        timetext.text = alive.ToString("N2");
    }

    public void gameOver()
    {
        anim.SetBool("isExplode", true);
        gameOverTxt.SetActive(true);
        Invoke("after_explode", 0.5f);
    }

    void after_explode()
    {
        Time.timeScale = 0.0f;
        Destroy(balloon);
    }
}
