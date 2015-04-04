using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class Grad {

	private int gradID;
	private string gradIme;
	private int gradBrojStanovnika;
	private int postanskiBroj;
	private string osnovniPodaci;
	private string zanimljivosti;


	public Grad(Dictionary<string, string> gradoviDict){
		gradIme = gradoviDict["GradIme"];
		gradID = int.Parse ( gradoviDict["GradID"]);
		gradBrojStanovnika = int.Parse(gradoviDict["GradBrojStanovnika"]);
		postanskiBroj = int.Parse(gradoviDict["PostasnkiBroj"]);
	}

	public int GradID {
		get{ return gradID;}
		set{ gradID = value;}
	}

	public string GradIme {
		get{ return gradIme;}
		set { gradIme = value;}
	}

	public int GradBrojStanovnika{
		get{return gradBrojStanovnika;}
		set{gradBrojStanovnika = value;}
	}

	public int PostanskiBroj{
		get{return postanskiBroj;}
		set{postanskiBroj = value;}
	}

	public string OsnovniPodaci {
		get{ return osnovniPodaci;}
		set { osnovniPodaci = value;}
	}

	public string Zanimljivosti {
		get{ return zanimljivosti;}
		set { zanimljivosti= value;}
	}
}
