using UnityEngine;
using System.Collections;

///
/// !!! Machine generated code !!!
/// !!! DO NOT CHANGE Tabs to Spaces !!!
/// 
[System.Serializable]
public class CardBaseData
{
  [SerializeField]
  int id;
  public int ID { get {return id; } set { this.id = value;} }
  
  [SerializeField]
  CardType cardtype;
  public CardType CARDTYPE { get {return cardtype; } set { this.cardtype = value;} }
  
  [SerializeField]
  string name_jp;
  public string Name_JP { get {return name_jp; } set { this.name_jp = value;} }
  
  [SerializeField]
  string name_en;
  public string Name_EN { get {return name_en; } set { this.name_en = value;} }
  
  [SerializeField]
  string information;
  public string Information { get {return information; } set { this.information = value;} }
  
}