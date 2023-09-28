using UnityEngine;
using System.Collections;
using static HealthSystemAttribute;

[AddComponentMenu("Playground/Attributes/Destroy For Points")]
public class DestroyForPointsAttribute : MonoBehaviour
{
	// List of item prefabs to spawn
    public GameObject[] itemPrefabs;
	public int health = 20;
	public int pointsWorth = 1;
    public GameObject deathEffectPrefab;


    private UIScript userInterface;

	private void Start()
	{
		// Find the UI in the scene and store a reference for later use
		userInterface = GameObject.FindObjectOfType<UIScript>();
	}

    private void SpawnRandomItem()
    {
        if (itemPrefabs.Length > 0)
        {
            int randomIndex = Random.Range(0, itemPrefabs.Length);
            GameObject randomItemPrefab = itemPrefabs[randomIndex];
            Instantiate(randomItemPrefab, transform.position, Quaternion.identity);
        }
    }

    //This will create a dialog window asking for which dialog to add
    private void Reset()
	{
		Utils.Collider2DDialogWindow(this.gameObject, false);
	}

	//duplication of the following function to accomodate both trigger and non-trigger Colliders
	private void OnCollisionEnter2D(Collision2D collisionData)
	{
		OnTriggerEnter2D(collisionData.collider);
	}

    private void PlayDeathEffect()
    {
        if (deathEffectPrefab != null)
        {
            GameObject deathEffect = Instantiate(deathEffectPrefab, transform.position, Quaternion.identity);
            Destroy(deathEffect, 2f); // Adjust the duration as needed
        }
    }

    // This function gets called everytime this object collides with another trigger
    private void OnTriggerEnter2D(Collider2D collisionData)
	{


			// is the other object a Bullet?
			if (collisionData.gameObject.CompareTag("Bullet"))
			{
            

            if (userInterface != null)
				{
					// add one point
					BulletAttribute b = collisionData.gameObject.GetComponent<BulletAttribute>();
					if (b != null)
					{
						userInterface.AddPoints(b.playerId, pointsWorth);
					}
					else
					{
						Debug.Log("Use a BulletAttribute on one of the objects involved in the collision if you want one of the players to receive points for destroying the target.");
					}
				}
				else
				{
					Debug.Log("There is no UI in the scene, hence points can't be displayed.");
				}

			// then destroy this object
			if (health <= 0)
			{
				PlayDeathEffect();
				SpawnRandomItem();
				Destroy(gameObject);
			}
			
				
			}
	}
}
