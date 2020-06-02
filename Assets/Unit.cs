using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
	public bool IsAlive { get; set; }
	public int PlayerNumber; 
	protected float health;
	protected int maxMoves;
	protected int movesRemaining;
	protected float AttackDamage = 5f;
	public float Health
	{
		get { return health; }
		set { health += value; if(Health <= 0) Death(); }
	}
	public float MaxHealth { get; set; }
	// Start is called before the first frame update
	void Start()
    {

    }
	public Unit()
	{
		IsAlive = true;

	}

    // Update is called once per frame

	public void Death()
	{
		Destroy(this);
	}
	public void Move()
	{
		
	}
	public void PerformAttack(GameObject enemyObject)
	{
		if (enemyObject.GetComponent<Unit>() != null && enemyObject.GetComponent<Unit>().PlayerNumber != PlayerNumber)
		{
			enemyObject.GetComponent<Unit>().Health -= AttackDamage;
		}
	}
}
