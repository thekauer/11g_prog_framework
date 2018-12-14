# Ez

## Mi ez? 

  Egy keretrendszert ami lehetővé teszi az órai feladatok gyors megoldását. 

## Hogy hasznalom? 

  1. Letöltöd az ez.cs filet a kód szekcióból. 
  2. Visual studioban miutan csináltál egy Console alkalmazást, jobb klick a projectedre->add existing file->keresd ki az ez.cs filet->megnyitás. 

## első programom
```c#
using Ez;
...

public static void Main(String[] args) {
  //Minden funkció 'ez.' -al kezdődik

  ez.WriteLine("Hello world");
  //egész szám beolvasása
  int szam = ez.BegFor<int>("Kérlek adj meg egy számot");
  //Használat BegFor< BEOLVASNI_KIVANT_TIPUS >("A beolvasas szovege. Ez opcionalis ha nem szeretnél hagyd üresen a zárójelet" ) ;
  
  //csinaljunk egy 5 elemű tömböt random szamokkal 1 és 10 között úgy hogy a számok a tömbben nem ismétlődhetnek
  int[] szamok = ez.random_szamos_tomb(5,1,10);
  //majd irrassuk ki a képernyőre
  szamok.kiír();
  //tegyük növekvő sorrendbe és újból írassuk ki
  szamok.rendez().kiír();

} 
```
