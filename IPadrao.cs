interface IPadrao
{
  //interface é pareciedo com classes abstratas, podem-se implementar varias
  //interfaces numa classe padrao,  todos os metodos de uma interface sao obrigatorios
  //nao precisa definir se é public, private ou abstract, o pdrao dele é publico

  //public void Soma(num1, num2) = NÃO
  //void Soma(num1, num2) = SIM, POR padrao já é e sempre será publico.
  void Somar(int n1, int n2);
  void Subtrair(int n1, int n2);
}