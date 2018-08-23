using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceManager : MonoBehaviour 
{
	enum RaceWeekendState 
	{
		RaceWeekendState_LoadTrack,
		RaceWeekendState_Practice,
		RaceWeekendState_Qualifying,
		RaceWeekendState_Race,
		RaceWeekendState_RaceOver
	}

	RaceWeekendState raceWeekendState;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		switch(raceWeekendState)
		{
			case RaceWeekendState.RaceWeekendState_LoadTrack:
			break;
			case RaceWeekendState.RaceWeekendState_Practice:
			break;
			case RaceWeekendState.RaceWeekendState_Qualifying:
			break;
			case RaceWeekendState.RaceWeekendState_Race:
			break;
			case RaceWeekendState.RaceWeekendState_RaceOver:
			break;
		}
	}

	void SetRaceWeekendState (RaceWeekendState eState) 
	{
		Debug.Log (eState);
		raceWeekendState = eState;
	}
}
