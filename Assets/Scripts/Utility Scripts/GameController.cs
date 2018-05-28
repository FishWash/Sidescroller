using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameController : MonoBehaviour
{

	/*
#region - Class Variables
	// Instance is a static reference to the current Instance of GameController,
	// for other Classes to access it.
	public static GameController Instance {get; private set;}

	public static Dictionary<string, GameObject> prefabDict = new Dictionary<string, GameObject>();
	[SerializeField] List<GameObject> prefabDictList;
#endregion

	#region - MonoBehaviour Methods

	void Awake ()
	{
		Instance = this;

		for (int i=0; i<prefabDictList.Count; i++)
		{
			prefabDict.Add(prefabDictList[i].name, prefabDictList[i]);
		}
	}

	void Update ()
	{

	}

	#endregion


	#region - Other Methods
  
	public static MonsterBehaviour InstantiateMonster(GameObject monsterToInstantiate, Vector3 position)
	{
		GameObject _monGo = PhotonNetwork.Instantiate("Monsters/" + monsterToInstantiate.name, position, Quaternion.identity, 0);
		MonsterBehaviour _mon = _monGo.GetComponent<MonsterBehaviour>();
		return _mon;
	}

	public static ActionBehaviour InstantiateAction(GameObject actionToInstantiate, Vector3 attackDirection, UnitBehaviour sourceUnit)
    {
		GameObject _actGo = PhotonNetwork.Instantiate("Actions/" + actionToInstantiate.name, sourceUnit.transform.position, Quaternion.identity, 0);
		ActionBehaviour _act = _actGo.GetComponent<ActionBehaviour>();
		_act.Initialize(attackDirection, sourceUnit);

		if (_act.instantiateAsChild)
			_act.transform.SetParent(sourceUnit.transform);
		return _act;
    }

	public static void InstantiateDamageNumber (int damageDealt, Transform sourceTransform, UnitBehaviour.Team teamColor)
	{
		GameObject _dnPref;
		if (GameController.prefabDict.TryGetValue("DamageNumber", out _dnPref))
		{
			DamageNumberBehaviour _dn = Instantiate(_dnPref, sourceTransform.position, Quaternion.identity).GetComponent<DamageNumberBehaviour>();
			_dn.SetNumber(damageDealt);
			_dn.SetDrift(Random.value - 0.5f);
			_dn.SetColor(teamColor);
		}
	}

	#endregion

#region - Math Stuff
	// Quick way of getting Quaternion form of angles.
	public static Quaternion RotationOfAngle(float angle)
	{
		return Quaternion.Euler(new Vector3( 0, 0, angle ));
	}

	public static Quaternion RotationOfVector(Vector2 vector)
	{
		return Quaternion.Euler( new Vector3(0, 0, Mathf.Atan2(vector.y, vector.x)*Mathf.Rad2Deg) );
	}

	// Used to determine sprite rendering layer of objects.
	public static void SetRenderingLayer (SpriteRenderer objectSprite, Transform objectTransform)
	{
		objectSprite.sortingOrder = (int) (objectTransform.position.y * -8);
	}
#endregion
*/
}

