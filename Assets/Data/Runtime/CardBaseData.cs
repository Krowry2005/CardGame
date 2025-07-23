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
  
  [SerializeField]
  int value;
  public int Value { get {return value; } set { this.value = value;} }
  
  [SerializeField]
  bool valuecard;
  public bool Valuecard { get {return valuecard; } set { this.valuecard = value;} }
  
  [SerializeField]
  Target target;
  public Target TARGET { get {return target; } set { this.target = value;} }
  
  [SerializeField]
  string magictype;
  public string Magictype { get {return magictype; } set { this.magictype = value;} }
  
}