
decimal funcaoRetornaQuantitadePOV(decimal porcentagem, int totalNegociado)
{
  return (totalNegociado + 10) * porcentagem;
}

Console.WriteLine(funcaoRetornaQuantitadePOV(0.1M, 90));
Console.WriteLine(funcaoRetornaQuantitadePOV(0.1M, 100));
Console.WriteLine(funcaoRetornaQuantitadePOV(0.2M, 70));
