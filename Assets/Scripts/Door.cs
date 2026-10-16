using Unity.Collections.Tests.CoreCLR.TestJobs;
using UnityEngine;

public class Door : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private BoxCollider collider;
    [SerializeField] private Material material;
    [SerializeField] private GameManager gameManager;

    private void Awake()
    {
        collider = GetComponent<BoxCollider>();
        collider.isTrigger = false;
        material.color = Color.red;
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            Debug.Log("We should show the win screen now!");

            gameManager.ShowWinScreen();
        }
    }

    public void UnlockDoor()
    {
        collider.isTrigger = true;
        material.color = Color.green;
    }
}
