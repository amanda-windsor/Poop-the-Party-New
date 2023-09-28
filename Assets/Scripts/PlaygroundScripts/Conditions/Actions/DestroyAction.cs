using UnityEngine;
using System.Collections;

[AddComponentMenu("Playground/Actions/Destroy Action")]
public class DestroyAction : Action
{
	//who gets destroyed in the collision?
	public Enums.Targets target = Enums.Targets.ObjectThatCollided;
	// assign an effect (explosion? particles?) or object to be created (instantiated) when the one gets destroyed
	public GameObject deathEffect;
    public AudioSource destroyBalloonSoundEffect;
    public AudioSource destroyPresentSoundEffect;
    public AudioSource destroyFurnitureSoundEffect;
    public AudioSource destroyCakeSoundEffect;

    //OtherObject is null when this Action is called from a Condition that is not collision-based
    public override bool ExecuteAction(GameObject otherObject)
	{
		if(deathEffect != null)
		{
			GameObject newObject = Instantiate<GameObject>(deathEffect);
			
			//move the effect depending on who needs to be destroyed
			Vector3 otherObjectPos = (otherObject == null) ? this.transform.position : otherObject.transform.position;
			newObject.transform.position = (target == Enums.Targets.ObjectThatCollided) ? otherObjectPos : this.transform.position;
		}

        if(otherObject.gameObject.name.Contains("Balloon"))

        {
			if (destroyBalloonSoundEffect != null)
			{
			destroyBalloonSoundEffect.Play();
			}
		}

        if (otherObject.gameObject.name.Contains("Present"))

        {
            if (destroyPresentSoundEffect != null)
            {
                destroyPresentSoundEffect.Play();
            }
        }

        if (otherObject.gameObject.name.Contains("Furniture"))

        {
            if (destroyFurnitureSoundEffect != null)
            {
                destroyFurnitureSoundEffect.Play();
            }
        }
        if (otherObject.gameObject.name.Contains("Cake"))

        {
            if (destroyCakeSoundEffect != null)
            {
                destroyCakeSoundEffect.Play();
            }
        }



        //remove the GameObject from the scene (destroy)
        if (target == Enums.Targets.ObjectThatCollided)
		{
			if(otherObject != null)
			{
				Destroy(otherObject);
			}
		}
		else
		{
			Destroy(gameObject);
		}

		return true; //always returns true
	}
}
