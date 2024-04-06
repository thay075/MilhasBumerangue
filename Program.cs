double percentualDeBonus, pecentualDeRetorno; 

double pontosATransferir, pontosAReduzir, pontosAAcrescentar; 

 

Console.Clear(); 

Console.WriteLine("--- Milhas Bumerangue ---\n"); 

 

Console.Write("Percentual de bônus....: "); 

percentualDeBonus = Convert.ToDouble(Console.ReadLine()); 

 

Console.Write("Percentual de retorno...: "); 

pecentualDeRetorno = Convert.ToDouble(Console.ReadLine()); 

 

Console.Write("Pontos a transferir....: "); 

pontosATransferir = Convert.ToDouble(Console.ReadLine()); 

 

pontosAReduzir = pontosATransferir - (pontosATransferir * percentualDeBonus) / 100; 

pontosAAcrescentar = pontosATransferir + (pontosATransferir * percentualDeBonus) / 100; 

 

Console.WriteLine(); 

Console.Write($"Pontos a reduzir na origem........: {pontosAReduzir}\n"); 

Console.Write($"Pontos a acrescentar no destino...: {pontosAAcrescentar}"); 

 