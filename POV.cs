namespace ADA_exercicios_lista1_parte2
{
  public static class POV
  {
    public static int FuncaoRetornaQuantitadePOV(decimal porcentagem, int totalNegociado)
    {
      var r = (totalNegociado / (1 - porcentagem)) - totalNegociado;
      return (int)Math.Truncate(r);
    }
  }
}
