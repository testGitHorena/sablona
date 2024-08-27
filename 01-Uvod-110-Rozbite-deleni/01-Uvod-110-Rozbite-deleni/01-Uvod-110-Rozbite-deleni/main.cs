using System;

class MainClass {
  public static void Main (string[] args) {
    double citatel = 32;
    double jmenovatel = 3;
      
    // Zde začíná záhada
          
    double podil = citatel / jmenovatel;
    double vysledekZpatky = podil * jmenovatel;
    
    // Zde záhada končí
    
    Console.WriteLine($"{citatel} / {jmenovatel} * {jmenovatel} = {vysledekZpatky}");

    
  }
}