import app.Conta;
public class ServicoConta {
	public String[] consultarDadosConta(int idConta) {

		System.out.println("Dentro do método consultarDadosConta() ");

		String[] dadosConta = null;

		try {

			Conta conta = new Conta();

			conta.setId(idConta);

			if (conta.recuperar()) {

				dadosConta = new String[3];

				dadosConta[0] = conta.getNome();

				dadosConta[1] = Double.toString(conta.getSaldo());

				dadosConta[2] = conta.getSenha();

			} else {

				System.out.println("Não foi possível recuperar a conta com o id " + idConta);

			}

		}catch (Exception e) {

			System.out.println("Erro no serviço consultarDadosConta: " + e.getMessage());

		}

		return dadosConta;

	}
	public double sacarConta(int idConta, double valorDeSaque) {
		System.out.println("Dentro do método sacarConta() ");

		double valorSaldo=0;
		try {

			Conta conta = new Conta();

			conta.setId(idConta);
			conta.recuperar();

			if (conta.saque(valorDeSaque)) {

				valorSaldo = conta.getSaldo();

			} else {

				System.out.println("Saque invalido para a conta com o id " + idConta);

			}

		}catch (Exception e) {

			System.out.println("Erro no serviço sacarConta: " + e.getMessage());

		}

		return valorSaldo;
	}
	public double depositarConta(int idConta, double valorDeDeposito) {
		System.out.println("Dentro do método depositarConta() ");

		double valorSaldo=0;
		try {

			Conta conta = new Conta();

			conta.setId(idConta);
			conta.recuperar();

			if (conta.deposito(valorDeDeposito)) {

				valorSaldo = conta.getSaldo();

			} else {

				System.out.println("Deposito invalido para a conta com o id " + idConta);

			}

		}catch (Exception e) {

			System.out.println("Erro no serviço depositarConta: " + e.getMessage());

		}
		return valorSaldo;
	}
	public boolean criarConta(String nome, String senha) {
		System.out.println("Dentro do metodo criarConta()");

		try {
			if(!nome.equals("") && !senha.equals("")) {
				Conta conta = new Conta();

				conta.setNome(nome);
				conta.setSenha(senha);

				if(conta.abrirConta()) {
					System.out.println("Conta criada com sucesso!");
					return true;
				}else {
					return false;
				}
			}else {
				return false;
			}
		}catch(Exception e){
			System.out.println("Erro no serviço criarConta: " + e.getMessage());
			return false;
		}
	}
}
