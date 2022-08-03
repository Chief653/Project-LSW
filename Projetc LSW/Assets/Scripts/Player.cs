using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {
    public GameObject StoreHUD;
    public Text moneyCurrent;
    public float playerSpeed, money;
    private Rigidbody2D rb;
    private Vector2 playerDirection;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
        moneyCurrent.text = "$ " + money;
    }

    void Update() {
        float directionX = Input.GetAxisRaw("Horizontal");
        float directionY = Input.GetAxisRaw("Vertical");

        playerDirection = new Vector2(directionX, directionY).normalized;
    }

    void FixedUpdate() {
        rb.velocity = new Vector2(playerDirection.x * playerSpeed, playerDirection.y * playerSpeed);
    }

    void OnTriggerEnter2D(Collider2D c1) { //Trocar para apertar E? Fazer o Lojista falar algo?
        if(c1.gameObject.tag == "Store") {
            StoreHUD.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D c1) {
        if(c1.gameObject.tag == "Store") {
            StoreHUD.SetActive(false);
        }
    }
}