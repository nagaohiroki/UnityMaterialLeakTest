using UnityEngine;
public class MaterialTest : MonoBehaviour
{
	[SerializeField]
	GameObject mGameObjectPrefab = null;
	GameObject mGameObject;
	void Update()
	{
		if(mGameObject == null)
		{
			if(Input.GetKeyDown(KeyCode.A))
			{
				mGameObject = Instantiate(mGameObjectPrefab);
			}
			return;
		}
		if(Input.GetKeyDown(KeyCode.D))
		{
			Destroy(mGameObject);
		}
	}
}
