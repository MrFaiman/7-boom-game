using System;

class Game {
  public static void Main (string[] args) {
    for(int i = 1; i <= 100; i++){
      if(i % 7 == 0){
        Console.WriteLine("boom");
      } else {
        Console.WriteLine(i);
      }
    }
  }
}