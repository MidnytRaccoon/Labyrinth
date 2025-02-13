using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField] public int health;
    [SerializeField] public int ammo;
    [SerializeField] public float reloadSpeed;
    [SerializeField] public float moveSpeed = 5f;
    [SerializeField] private Vector3 moveDirection;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<Renderer>().material.color = Color.orange;
        health = 100;
        ammo = 50;
        reloadSpeed = 1f;
    }
    void Update()
    {
        getInput();
    }
    public void getInput(){
    moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    transform.Translate(moveDirection * moveSpeed * Time.deltaTime, Space.World);
    }
}
