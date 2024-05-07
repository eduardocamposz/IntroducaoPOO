using ExemploAula;

namespace IntroducaoPooTests
{
    [TestClass]
    public class ContaTest
    {
        [TestMethod]
        public void DepositoTest()
        {
            //cenario
            Conta conta1 = new Conta(123, 1000);
            decimal valorDepositado = 1000;
            decimal SaldoDesejado = 2000;

            //ação
            conta1.Deposito(valorDepositado);

            //verificação
            Assert.AreEqual(SaldoDesejado, conta1.Saldo);
        }
        //escreva o código de teste para saque em conta
        //atualize o diagrama da classe de modo que represente corretamente a classe conta
    }
}