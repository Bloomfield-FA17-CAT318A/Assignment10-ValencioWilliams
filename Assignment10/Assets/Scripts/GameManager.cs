using System.Collections;
using System.Collections.Generic;
using UnityEngine.Analytics;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	void FavoriteColor ()
	{
		Analytics.CustomEvent ("Favorite Color");
	}
}
