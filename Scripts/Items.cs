using UnityEngine;
using System.Collections;

public class Items : MonoBehaviour {


	public void Info(int i, out string n, out string d) {

		n = "null item";
		d = "null description.";

		switch(i) {

		case 0:
			n = "test item 0";
			d = "test description 0.";
			break;
		case 1:
			n = "test item 1";
			d = "test description 1.";
			break;
		}

	}
}
