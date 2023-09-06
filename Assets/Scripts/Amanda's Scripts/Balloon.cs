using UnityEngine;

// public class Balloon : MonoBehaviour
// {
//     public GameObject popPrefab; // Reference to prefab for pop animation
//     public float popForce = 5f; // Force applied to balloon when popped

//     private bool isPopped = false; // Flag to check if balloon has been popped
//     private Rigidbody2D rb; // Reference to the balloon's rigidbody

//     void Start()
//     {
//         // Get reference to the balloon's rigidbody
//         rb = GetComponent<Rigidbody2D>();
//     }

//     void OnMouseDown()
//     {
//         // Check if the balloon has already been popped
//         if(!isPopped)
//         {
//             // Create an instance of the pop animation prefab
//             GameObject pop = Instantiate(popPrefab, transform.position, Quaternion.identity);

//             // Apply a force to the balloon to simulate a pop
//             rb.AddForce(Vector2.up * popForce, ForceMode2D.Impulse);

//             // Set flag to indicate that the balloon has been popped
//             isPopped = true;

//             // Destroy the balloon and pop animation after a delay
//             Destroy(gameObject, 0.5f);
//             Destroy(pop, 1f);
//         }
//     }
// }