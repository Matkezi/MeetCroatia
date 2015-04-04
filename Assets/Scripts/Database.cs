using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.IO;
using System.Text.RegularExpressions;
using System.Text;
using UnityEngine.UI;
using System;


public class Database : MonoBehaviour {


	public TextAsset Gradovi;
	public static List<Grad> listaGradova = new List<Grad>();

	public List<Dictionary<string, string>> dictGradovi = new List<Dictionary<string,string>>();
	public Dictionary<string,string> sviGradovi;

	void Awake(){
		CitajGradoveIzBaze();
		GradIme();

		

	}



	public void CitajGradoveIzBaze(){
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(Gradovi.text);
		XmlNodeList gradList = xmlDocument.GetElementsByTagName("Grad");

		foreach(XmlNode gradInfo in gradList){
			XmlNodeList gradPodaci = gradInfo.ChildNodes;
			sviGradovi = new Dictionary<string, string>();


			foreach(XmlNode podaci in gradPodaci){
				switch(podaci.Name){
				case "GradIme":
					sviGradovi.Add("GradIme",podaci.InnerText);
					break;
				case "GradID":
					sviGradovi.Add("GradID",podaci.InnerText);
					break;
				case "GradBrojStanovnika":
					sviGradovi.Add("GradBrojStanovnika",podaci.InnerText);
					break;
				case "PostanskiBroj":
					sviGradovi.Add("PostanskiBroj",podaci.InnerText);
					break;
				case "OsnovniPodaci":
					sviGradovi.Add("OsnovniPodaci",podaci.InnerText);
					break;
				case "Zanimljivosti":
					sviGradovi.Add("Zanimljivosti",podaci.InnerText);
					break;
				}
			}

			dictGradovi.Add(sviGradovi);
		}
	}

	public void GradIme(){
		Text textscript = GameObject.Find ("ScrollText").GetComponentInChildren<Text>();
		textscript.text = dictGradovi[0]["OsnovniPodaci"] + "\n" + "--------------------------------------" + "\n" + dictGradovi[0]["Zanimljivosti"];
	}
}
